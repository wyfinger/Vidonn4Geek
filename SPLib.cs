// Vidonn X5 Reverse
// Wyfinger / wyfinger@yandex.ru

using System;
using System.Collections;
using System.IO.Ports;
using System.Text;    // Оно тут нужно ?
using System.Windows.Forms;

namespace ComLib
{
    
    public class SPLib
    {

        
        public struct PersonCfg
        {
            public int weight;
            public int height;
            public bool female;
            public int age;
            public int goal;
        }

        public SerialPort VSerialPort;
        public bool IsReciving;
        public string MyPortName = "";
        public string ReturnData = "";
        private int WaitDelay = 10000; // TODO: изменить на 1000 в релизе !!!!

        public SPLib()
        {
            this.VSerialPort = new SerialPort();
        }

        /// <summary>
        ///     true если порт отрыт
        /// </summary>
        public bool IsOpen
        {
            get
            {
                return this.VSerialPort.IsOpen;
            }
        }

        /// <summary>
        ///     Попытка открыть порт
        /// </summary>
        /// <param name="portName">Имя порта, например "COM1"</param>
        /// <returns>true если все хорошо</returns>       
        public bool Open(string portName)
        {
            bool result;
            try
            {
                this.VSerialPort.PortName = portName;
                this.VSerialPort.ReceivedBytesThreshold = 1;
                this.VSerialPort.BaudRate = 115200;
                this.VSerialPort.DataBits = 8;
                this.VSerialPort.StopBits = StopBits.One;
                this.VSerialPort.Parity = Parity.None;
                this.VSerialPort.WriteTimeout = 1000;
                this.VSerialPort.ReadTimeout = 1000;
                this.VSerialPort.NewLine = "\r\n";
                this.VSerialPort.DataReceived += new SerialDataReceivedEventHandler(this.OnReceiveFunc);
                this.VSerialPort.Open();
                result = this.VSerialPort.IsOpen;
            }
            catch
            {
                result = false;
            }
            return result;
        }

        /// <summary>
        ///     Закрыть открытый порт
        /// </summary>      
        public void Close()
        {
            this.VSerialPort.DataReceived -= new SerialDataReceivedEventHandler(this.OnReceiveFunc);
            int tickCount = Environment.TickCount;
            while (Environment.TickCount - tickCount < this.WaitDelay && this.IsReciving)
            {
                Application.DoEvents();
            }
            this.VSerialPort.Close();
        }

        /// <summary>
        ///     Проверка версии прошивки устройства
        /// </summary>
        /// <returns>Версия прошивки, "01" или "02"</returns>        
        public string CheckVers()
        {
            string result = "";
            try
            {
                this.Send("AA 80 00 F0 00 00");
                int tickCount = Environment.TickCount;
                this.IsReciving = true;
                while (Environment.TickCount - tickCount < this.WaitDelay && this.IsReciving)
                {
                    Application.DoEvents();
                }
                if (!(this.ReturnData.Trim() == "AA0000F003020100") && !(this.ReturnData.Trim() == "AA0000F002020101"))
                {
                    if (this.ReturnData.Trim().Trim() == "AA0000F000020200")
                    {
                        result = "02";
                    }
                }
                else
                {
                    result = "01";
                }
            }
            catch
            {
                result = "";
            }
            return result;
        }

        /// <summary>
        ///     Похоже на проверку бренда, возможно одина и та же начинка продается в разных форма-факторах
        /// </summary>
        /// <returns>true если все Ok</returns>        
        public bool CheckBand()
        {
            bool result = false;
            try
            {
                this.Send("AA 80 10 F0 00 00");
                int tickCount = Environment.TickCount;
                this.IsReciving = true;
                while (Environment.TickCount - tickCount < this.WaitDelay && this.IsReciving)
                {
                    Application.DoEvents();
                }
                if (this.ReturnData.Length > 30)
                {
                    string a = this.ReturnData.Substring(14, 12);
                    if (a == "5669646F6E6E")     // "Vidonn"
                    {
                        result = true;
                    }
                }
            }
            catch
            {
                result = false;
            }
            return result;
        }

        /// <summary>
        ///     Чтение бренда, это на случай, если есть такие же браслеты, отличающиеся только брендом
        /// </summary>
        /// <returns>6 байт начиная с 8 в ответе, сконвертированные в строку</returns>
        public string GetBand()
        {
            string result = "";
            try
            {
                this.Send("AA 80 10 F0 00 00");
                int tickCount = Environment.TickCount;
                this.IsReciving = true;
                while (Environment.TickCount - tickCount < this.WaitDelay && this.IsReciving)
                {
                    Application.DoEvents();
                }
                if (this.ReturnData.Length > 30)
                {
                    byte[] buffer = this.HexStr2ByteArr(this.ReturnData.Substring(14, 12));
                    result = Encoding.Default.GetString(buffer);
                }
            }
            catch
            {
                result = "";
            }
            return result;
        }

        /// <summary>
        ///     Получение значения даты/времени с устройства
        /// </summary>
        /// <returns>Строка в форате, понятном </returns> 
        // TODO: написать в каком формате (после проверки на устройстве) 
        public string GetTime()
        {
            string result = "";
            try
            {
                this.Send("AA 80 16 F0 00 00");
                int tickCount = Environment.TickCount;
                this.IsReciving = true;
                while (Environment.TickCount - tickCount < 2 * this.WaitDelay && this.IsReciving)
                {
                    Application.DoEvents();  // TODO: не забыть переименовать строковые переменные во что-тот типа hh, yyyy !!!
                }
                string text = this.ReturnData.Trim();
                string yyyy = text.Substring(14, 2);
                yyyy = "00" + Convert.ToInt32(yyyy, 16).ToString();
                yyyy = "20" + yyyy.Substring(yyyy.Length - 2, 2);    // года 4 значные
                string MM = text.Substring(16, 2);
                MM = (1 + Convert.ToInt32(MM, 16)).ToString();
                string dd = text.Substring(18, 2);
                dd = (1 + Convert.ToInt32(dd, 16)).ToString();
                string hh = text.Substring(20, 2);
                hh = Convert.ToInt32(hh, 16).ToString();
                string mm = text.Substring(22, 2);
                mm = Convert.ToInt32(mm, 16).ToString();
                string ss = text.Substring(24, 2);
                ss = Convert.ToInt32(ss, 16).ToString();
                result = string.Concat(new string[]  {yyyy, "-", MM, "-", dd, " ",hh, ":", mm, ":", ss});
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return result;
        }

        /// <summary>
        ///     Установка даты/времени в устройство
        /// </summary>
        /// <param name="newDatetime">Строка даты/времени в формате, понятном Convert.ToDateTime()</param>
        /// <returns></returns>        
        public bool SetTime(string newDatetime)
        {
            bool result = false;
            try
            {
                DateTime dateTime = Convert.ToDateTime(newDatetime);
                string yy = dateTime.ToString("yy");
                string MM = dateTime.ToString("MM");
                string dd = dateTime.ToString("dd");
                string HH = dateTime.ToString("HH");
                string mm = dateTime.ToString("mm");
                string ss = dateTime.ToString("ss");
                yy = int.Parse(yy).ToString("X");
                yy = ((yy.Length < 2) ? ("0" + yy) : yy);
                MM = (int.Parse(MM) - 1).ToString("X");
                MM = ((MM.Length < 2) ? ("0" + MM) : MM);
                dd = (int.Parse(dd) - 1).ToString("X");
                dd = ((dd.Length < 2) ? ("0" + dd) : dd);
                HH = int.Parse(HH).ToString("X");
                HH = ((HH.Length < 2) ? ("0" + HH) : HH);
                mm = int.Parse(mm).ToString("X");
                mm = ((mm.Length < 2) ? ("0" + mm) : mm);
                ss = int.Parse(ss).ToString("X");
                ss = ((ss.Length < 2) ? ("0" + ss) : ss);
                string dateTimeStr = string.Concat(new string[] { yy, " ", MM, " ", dd, " ", HH, " ", mm, " ", ss });

                string parameter2 = "AA 81 16 F0 " + this.PrepareHexStr_1(dateTimeStr);
                this.Send(parameter2);
                int tickCount = Environment.TickCount;
                this.IsReciving = true;
                while (Environment.TickCount - tickCount < 2 * this.WaitDelay && this.IsReciving)
                {
                    Application.DoEvents();
                }
                string a = this.ReturnData.Trim();
                if (a == "AA0116F0000101")
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return result;
        }

        /// <summary>
        ///     Получение из устройства персональной информации
        /// </summary>
        /// <returns>Структура PersonCfg</returns>        
        public SPLib.PersonCfg GetPersonConfig()
        {
            SPLib.PersonCfg result = default(SPLib.PersonCfg);
            try
            {
                this.Send("AA 80 13 F0 00 00");
                int tickCount = Environment.TickCount;
                this.IsReciving = true;
                while (Environment.TickCount - tickCount < 2 * this.WaitDelay && this.IsReciving)
                {
                    Application.DoEvents();
                }
                string text = this.ReturnData.Trim();
                string height = text.Substring(14, 2);
                result.height = Convert.ToInt32(height, 16);   // рост
                string weight = text.Substring(16, 2);
                result.weight = Convert.ToInt32(weight, 16);   // вес
                string female = text.Substring(18, 2);         // пол
                if (female == "00")
                {
                    result.female = false;
                }
                else
                {
                    result.female = true;
                }
                string age = text.Substring(20, 2);            // возраст
                result.age = Convert.ToInt32(age, 16);
                string goal_low = text.Substring(24, 2);
                string goal_hi = text.Substring(22, 2);
                result.goal = Convert.ToInt32(goal_low, 16) * 256 + Convert.ToInt32(goal_hi, 16); 
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return result;
        }

        /// <summary>
        ///     Установка в устройство персональных натсроек
        /// </summary>
        /// <param name="pcfs">Структура PersonCfg</param>
        /// <returns>true если все хорошо</returns>       
        public bool SetPersonConfig(SPLib.PersonCfg pcfs)
        {
            bool result = false;
            try
            {
                string height = pcfs.height.ToString("X");
                height = ((height.Length < 2) ? ("0" + height) : height);
                string weight = pcfs.weight.ToString("X");
                weight = ((weight.Length < 2) ? ("0" + weight) : weight);
                string female = "00";
                if (pcfs.female)
                {
                    female = "01";
                }
                string age = pcfs.age.ToString("X");
                age = ((age.Length < 2) ? ("0" + age) : age);

                string goal = "0000" + pcfs.goal.ToString("X");
                goal = goal.Substring(goal.Length - 4, 4);

                string goal_low = goal.Substring(2, 2);
                string goal_hi = goal.Substring(0, 2);
                string parameter = string.Concat(new string[] { height, " ", weight, " ", female, " ", age, " ", goal_low, " ", goal_hi });
                string parameter2 = "AA 81 13 F0 " + this.PrepareHexStr_1(parameter);
                this.Send(parameter2);
                int tickCount = Environment.TickCount;
                this.IsReciving = true;
                while (Environment.TickCount - tickCount < 2 * this.WaitDelay && this.IsReciving)
                {
                    Application.DoEvents();
                }
                string a = this.ReturnData.Trim();
                if (a == "AA0113F0000101")
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return result;
        }

        /// <summary>
        ///     Получение идентификационного номера устройства
        /// </summary>
        /// <returns>6 байт в виде hex строки</returns>             
        public string getBmac()
        {
            string result = "";
            try
            {
                this.Send("AA 80 15 F0 00 00");
                int tickCount = Environment.TickCount;
                this.IsReciving = true;
                while (Environment.TickCount - tickCount < 2 * this.WaitDelay && this.IsReciving)
                {
                    Application.DoEvents();
                }
                string text = this.ReturnData.Trim();
                if (text.Length > 26)
                {
                    result = text.Substring(14, 12);
                }
                else
                {
                    result = "";
                }
            }
            catch
            {
                result = "";
            }
            return result;
        }

        
        public string GetSitConfig()
        {
            string result = "";
            try
            {
                this.Send("AA 80 1B F0 00 00");
                int tickCount = Environment.TickCount;
                this.IsReciving = true;
                while (Environment.TickCount - tickCount < 2 * this.WaitDelay && this.IsReciving)
                {
                    Application.DoEvents();
                }
                this.ReturnData.Trim();
                if (this.ReturnData.Length > 20)
                {
                    result = this.ReturnData.Substring(16, 2);
                }
            }
            catch
            {
                result = "";
            }
            return result;
        }

        
        public bool setSitConfig(string sitCfg)
        {
            bool result = false;
            try
            {
                string parameter = sitCfg + " 00 00 00 00 00 00 00 00 00 00 00 00 00 00";
                string parameter2 = "AA 81 1B F0 " + this.PrepareHexStr_4(parameter);
                this.Send(parameter2);
                int tickCount = Environment.TickCount;
                this.IsReciving = true;
                while (Environment.TickCount - tickCount < 2 * this.WaitDelay && this.IsReciving)
                {
                    Application.DoEvents();
                }
                string a = this.ReturnData.Trim();
                if (a == "AA0118F0000101")
                {
                    result = true;
                }
            }
            catch
            {
                result = false;
            }
            return result;
        }

        /// <summary>
        ///     Обработчик получения данных из COM порта
        /// </summary>
        /// <param name="sender">Объект SerialPort</param>
        /// <param name="e">Событие</param>
        private void OnReceiveFunc(object sender, SerialDataReceivedEventArgs e)
        {
            this.IsReciving = true;
            int bytesToRead = this.VSerialPort.BytesToRead;
            if (bytesToRead < 1)
            {
                return;
            }
            byte[] array = new byte[bytesToRead];
            this.VSerialPort.Read(array, 0, bytesToRead);
            string text = "";
            for (int i = 0; i < array.Length; i++)
            {
                text += string.Format("{0:X2}", array[i]);
            }
            this.ReturnData = text;
            this.IsReciving = false;
        }

        /// <summary>
        ///     Отправить последовательность байтов в порт
        /// </summary>
        /// <param name="hexStr"></param>
        private void Send(string hexStr)
        {
            try
            {
                if (!this.VSerialPort.IsOpen)
                {
                    this.Open(this.MyPortName);
                }
                string text = hexStr.Replace(" ", "");
                new ArrayList();
                int count = text.Length / 2;
                byte[] buffer = this.HexStr2ByteArr(hexStr);
                this.VSerialPort.Write(buffer, 0, count);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }


        public string[,] getSptdata()
        {
            string[,] array = new string[168, 5];
            try
            {
                this.Send("AA 80 13 F0 00 00");
                int tickCount = Environment.TickCount;
                this.IsReciving = true;
                while (Environment.TickCount - tickCount < 2 * this.WaitDelay && this.IsReciving)
                {
                    Application.DoEvents();
                }
                string text = this.ReturnData.Trim();
                int num = Convert.ToInt32(text.Substring(16, 2), 16);
                if (num < 1 || num > 250)
                {
                    num = 80;
                }
                this.Send("AA 81 14 F0 88 11 f5 00 77 1b 00 00 00 00 00 00 00 00 00 00 00 00 00");
                tickCount = Environment.TickCount;
                this.IsReciving = true;
                while (Environment.TickCount - tickCount < 2 * this.WaitDelay && this.IsReciving)
                {
                    Application.DoEvents();
                }
                for (int i = 0; i < 56; i++)
                {
                    this.Send("AA 80 14 F0 00 00");
                    tickCount = Environment.TickCount;
                    this.IsReciving = true;
                    while (Environment.TickCount - tickCount < 2 * this.WaitDelay && this.IsReciving)
                    {
                        Application.DoEvents();
                    }
                    string text2 = this.ReturnData.Trim();
                    if (text2.Length >= 20)
                    {
                        string[] array2 = this.HexStr2HexArr(text2);
                        string parameter = text2.Substring(16, 4);
                        string text3 = this.Method16(parameter);
                        string s = array2[7].Substring(0, 1);
                        string s2 = array2[7].Substring(1, 1);
                        if (int.Parse(s2) < 4)
                        {
                            for (int j = 0; j < 6; j++)
                            {
                                array[j + 6 * int.Parse(s2) + 24 * int.Parse(s), 0] = text3;
                                array[j + 6 * int.Parse(s2) + 24 * int.Parse(s), 1] = (j + 6 * int.Parse(s2)).ToString();
                                array[j + 6 * int.Parse(s2) + 24 * int.Parse(s), 2] = (Convert.ToInt32(array2[10 + 2 * j], 16) + Convert.ToInt32(array2[11 + 2 * j], 16) * 256).ToString();
                            }
                        }
                        else
                        {
                            for (int k = 0; k < 6; k++)
                            {
                                array[k + 6 * (int.Parse(s2) - 4) + 24 * int.Parse(s), 3] = (Convert.ToInt32(array2[10 + 2 * k], 16) + Convert.ToInt32(array2[11 + 2 * k], 16) * 256).ToString();
                                array[k + 6 * (int.Parse(s2) - 4) + 24 * int.Parse(s), 4] = (num * (Convert.ToInt32(array2[10 + 2 * k], 16) + Convert.ToInt32(array2[11 + 2 * k], 16) * 256) / 800).ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return array;
        }

        /// <summary>
        ///     Получение информации по будильникам
        /// </summary>
        /// <returns></returns>
        public string[,] GetAlarmSet()
        {
            string[,] array = new string[8, 11];
            try
            {
                for (int i = 0; i < 2; i++)
                {
                    this.Send("AA 80 17 F0 00 00");
                    int tickCount = Environment.TickCount;
                    this.IsReciving = true;
                    while (Environment.TickCount - tickCount < 2 * this.WaitDelay && this.IsReciving)
                    {
                        Application.DoEvents();
                    }
                    string text = this.ReturnData.Trim();
                    if (text.Length >= 20)
                    {
                        string[] array2 = this.HexStr2HexArr(text);
                        if (array2[7] == "00")   // второй ответ
                        {
                            array[0, 0] = array2[8];
                            string[] array3 = this.HexByte2BiteArr(array2[9]);
                            for (int j = 0; j < 8; j++)
                            {
                                array[0, j + 1] = array3[j];
                            }
                            array[0, 9] = Convert.ToInt32(array2[10], 16).ToString();
                            array[0, 10] = Convert.ToInt32(array2[11], 16).ToString();
                            array[1, 0] = array2[12];
                            array3 = this.HexByte2BiteArr(array2[13]);
                            for (int k = 0; k < 8; k++)
                            {
                                array[1, k + 1] = array3[k];
                            }
                            array[1, 9] = Convert.ToInt32(array2[14], 16).ToString();
                            array[1, 10] = Convert.ToInt32(array2[15], 16).ToString();
                            array[2, 0] = array2[16];
                            array3 = this.HexByte2BiteArr(array2[17]);
                            for (int l = 0; l < 8; l++)
                            {
                                array[2, l + 1] = array3[l];
                            }
                            array[2, 9] = Convert.ToInt32(array2[18], 16).ToString();
                            array[2, 10] = Convert.ToInt32(array2[19], 16).ToString();
                            array[3, 0] = array2[20];
                            array3 = this.HexByte2BiteArr(array2[21]);
                            for (int m = 0; m < 8; m++)
                            {
                                array[3, m + 1] = array3[m];
                            }
                            array[3, 9] = Convert.ToInt32(array2[22], 16).ToString();
                            array[3, 10] = Convert.ToInt32(array2[23], 16).ToString();
                        }
                        else               // первый ответ
                        {
                            array[4, 0] = array2[8];
                            string[] array4 = this.HexByte2BiteArr(array2[9]);
                            for (int n = 0; n < 8; n++)
                            {
                                array[4, n + 1] = array4[n];
                            }
                            array[4, 9] = Convert.ToInt32(array2[10], 16).ToString();
                            array[4, 10] = Convert.ToInt32(array2[11], 16).ToString();
                            array[5, 0] = array2[12];
                            array4 = this.HexByte2BiteArr(array2[13]);
                            for (int num = 0; num < 8; num++)
                            {
                                array[5, num + 1] = array4[num];
                            }
                            array[5, 9] = Convert.ToInt32(array2[14], 16).ToString();
                            array[5, 10] = Convert.ToInt32(array2[15], 16).ToString();
                            array[6, 0] = array2[16];
                            array4 = this.HexByte2BiteArr(array2[17]);
                            for (int num2 = 0; num2 < 8; num2++)
                            {
                                array[6, num2 + 1] = array4[num2];
                            }
                            array[6, 9] = Convert.ToInt32(array2[18], 16).ToString();
                            array[6, 10] = Convert.ToInt32(array2[19], 16).ToString();
                            array[7, 0] = array2[20];
                            array4 = this.HexByte2BiteArr(array2[21]);
                            for (int num3 = 0; num3 < 8; num3++)
                            {
                                array[7, num3 + 1] = array4[num3];
                            }
                            array[7, 9] = Convert.ToInt32(array2[22], 16).ToString();
                            array[7, 10] = Convert.ToInt32(array2[23], 16).ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return array;
        }
        
        /// <summary>
        ///     Запись информации по будильникам
        /// </summary>
        /// <param name="arrInput"></param>
        /// <returns></returns>
        public bool SetAlarmSet(string[,] arrInput)
        {
            bool result = false;
            try
            {
                string[] array = new string[8];
                string[] array2 = new string[8];
                string[] array3 = new string[8];
                for (int i = 0; i < 8; i++)
                {
                    string text = "";
                    for (int j = 1; j < 9; j++)
                    {
                        text += arrInput[i, j];
                    }
                    text = Convert.ToInt32(text, 2).ToString("X");
                    text = ((text.Length < 2) ? ("0" + text) : text);
                    array[i] = text;
                    string text2 = Convert.ToInt32(arrInput[i, 9]).ToString("X");
                    text2 = ((text2.Length < 2) ? ("0" + text2) : text2);
                    array2[i] = text2;
                    string text3 = Convert.ToInt32(arrInput[i, 10]).ToString("X");
                    text3 = ((text3.Length < 2) ? ("0" + text3) : text3);
                    array3[i] = text3;
                }
                string text4 = string.Concat(new string[]
{
arrInput[0, 0],
" ",
array[0],
" ",
array2[0],
" ",
array3[0],
" ",
arrInput[1, 0],
" ",
array[1],
" ",
array2[1],
" ",
array3[1],
" ",
arrInput[2, 0],
" ",
array[2],
" ",
array2[2],
" ",
array3[2],
" ",
arrInput[3, 0],
" ",
array[3],
" ",
array2[3],
" ",
array3[3]
});
                string parameter = "AA 81 17 F0 " + this.PrepareHexStr_2(text4);
                this.Send(parameter);
                int tickCount = Environment.TickCount;
                this.IsReciving = true;
                while (Environment.TickCount - tickCount < 2 * this.WaitDelay && this.IsReciving)
                {
                    Application.DoEvents();
                }
                string a = this.ReturnData.Trim();
                if (a == "AA0117F0000101")
                {
                    text4 = string.Concat(new string[]
{
arrInput[4, 0],
" ",
array[4],
" ",
array2[4],
" ",
array3[4],
" ",
arrInput[5, 0],
" ",
array[5],
" ",
array2[5],
" ",
array3[5],
" ",
arrInput[6, 0],
" ",
array[6],
" ",
array2[6],
" ",
array3[6],
" ",
arrInput[7, 0],
" ",
array[7],
" ",
array2[7],
" ",
array3[7]
});
                    parameter = "AA 81 17 F0 " + this.PrepareHexStr_3(text4);
                    this.Send(parameter);
                    tickCount = Environment.TickCount;
                    this.IsReciving = true;
                    while (Environment.TickCount - tickCount < 2 * this.WaitDelay && this.IsReciving)
                    {
                        Application.DoEvents();
                    }
                    a = this.ReturnData.Trim();
                    if (a == "AA0117F0000101")
                    {
                        result = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return result;
        }

        /// <summary>
        ///     Старая версия запроса информации по будильникам, похоже для firmware= 01
        /// </summary>
        /// <returns></returns>
        public string[,] GetOldAlarmSet()
        {
            string[,] array = new string[16, 8];
            try
            {
                this.Send("AA 80 01 F0 00 00");
                int tickCount = Environment.TickCount;
                this.IsReciving = true;
                while (Environment.TickCount - tickCount < 2 * this.WaitDelay && this.IsReciving)
                {
                    Application.DoEvents();
                }
                string parameter = this.ReturnData.Trim();
                string[] arrAnswer = this.HexStr2HexArr(parameter);
                string[] arrAnswerBite6 = this.HexByte2BiteArr(arrAnswer[6]);
                for (int i = 0; i < 8; i++)
                {
                    array[0, i] = arrAnswerBite6[i];
                }
                arrAnswerBite6 = this.HexByte2BiteArr(arrAnswer[7]);
                for (int j = 0; j < 8; j++)
                {
                    array[1, j] = arrAnswerBite6[j];
                }
                arrAnswerBite6 = this.HexByte2BiteArr(arrAnswer[8]);
                for (int k = 0; k < 8; k++)
                {
                    array[2, k] = arrAnswerBite6[k];
                }
                arrAnswerBite6 = this.HexByte2BiteArr(arrAnswer[9]);
                for (int l = 0; l < 8; l++)
                {
                    array[3, l] = arrAnswerBite6[l];
                }
                arrAnswerBite6 = this.HexByte2BiteArr(arrAnswer[10]);
                for (int m = 0; m < 8; m++)
                {
                    array[4, m] = arrAnswerBite6[m];
                }
                arrAnswerBite6 = this.HexByte2BiteArr(arrAnswer[11]);
                for (int n = 0; n < 8; n++)
                {
                    array[5, n] = arrAnswerBite6[n];
                }
                arrAnswerBite6 = this.HexByte2BiteArr(arrAnswer[12]);
                for (int num = 0; num < 8; num++)
                {
                    array[6, num] = arrAnswerBite6[num];
                }
                arrAnswerBite6 = this.HexByte2BiteArr(arrAnswer[13]);
                for (int num2 = 0; num2 < 8; num2++)
                {
                    array[7, num2] = arrAnswerBite6[num2];
                }
                arrAnswerBite6 = this.HexByte2BiteArr(arrAnswer[14]);
                for (int num3 = 0; num3 < 8; num3++)
                {
                    array[8, num3] = arrAnswerBite6[num3];
                }
                arrAnswerBite6 = this.HexByte2BiteArr(arrAnswer[15]);
                for (int num4 = 0; num4 < 8; num4++)
                {
                    array[9, num4] = arrAnswerBite6[num4];
                }
                arrAnswerBite6 = this.HexByte2BiteArr(arrAnswer[16]);
                for (int num5 = 0; num5 < 8; num5++)
                {
                    array[10, num5] = arrAnswerBite6[num5];
                }
                arrAnswerBite6 = this.HexByte2BiteArr(arrAnswer[17]);
                for (int num6 = 0; num6 < 8; num6++)
                {
                    array[11, num6] = arrAnswerBite6[num6];
                }
                arrAnswerBite6 = this.HexByte2BiteArr(arrAnswer[18]);
                for (int num7 = 0; num7 < 8; num7++)
                {
                    array[12, num7] = arrAnswerBite6[num7];
                }
                arrAnswerBite6 = this.HexByte2BiteArr(arrAnswer[19]);
                for (int num8 = 0; num8 < 8; num8++)
                {
                    array[13, num8] = arrAnswerBite6[num8];
                }
                arrAnswerBite6 = this.HexByte2BiteArr(arrAnswer[20]);
                for (int num9 = 0; num9 < 8; num9++)
                {
                    array[14, num9] = arrAnswerBite6[num9];
                }
                arrAnswerBite6 = this.HexByte2BiteArr(arrAnswer[21]);
                for (int num10 = 0; num10 < 8; num10++)
                {
                    array[15, num10] = arrAnswerBite6[num10];
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return array;
        }

        /// <summary>
        ///     Упаковка HEX строки байтов в байтовый массив
        /// </summary>
        /// <param name="inputString">Строка HEX байтов, можно с пробелами</param>
        /// <returns></returns>      
        private byte[] HexStr2ByteArr(string inputString)
        {
            byte[] result = null;
            try
            {
                string text = inputString.Replace(" ", "");
                ArrayList arrayList = new ArrayList();
                int num = text.Length / 2;
                for (int i = 0; i < num; i++)
                {
                    string text2 = text.Substring(2 * i, 2);
                    byte b;
                    try
                    {
                        b = Convert.ToByte(text2, 16);
                    }
                    catch
                    {
                        throw new Exception("Error:" + text2);
                    }
                    arrayList.Add(b);
                }
                result = (byte[])arrayList.ToArray(typeof(byte));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return result;
        }

        /// <summary>
        ///     Преобразование строки с HEX байтами в массив с этими же байтами (по два 16 ричных символа)
        /// </summary>
        /// <param name="inputString">Строка HEX байтов, можно с пробелами</param>
        /// <returns></returns>
        private string[] HexStr2HexArr(string inputString)
        {
            string[] result = null;
            try
            {
                string text = inputString.Replace(" ", "");
                ArrayList arrayList = new ArrayList();
                int num = text.Length / 2;
                for (int i = 0; i < num; i++)
                {
                    string text2 = text.Substring(2 * i, 2);
                    string value = text2;
                    arrayList.Add(value);
                }
                result = (string[])arrayList.ToArray(typeof(string));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return result;
        }

        /// <summary>
        ///     Преобразование байта, заданного как Hex строка в массив бит (строк)
        /// </summary>
        /// <param name="hexByte">Байт в виде Hex строки</param>
        /// <returns></returns>
        private string[] HexByte2BiteArr(string hexByte)
        {
            string[] array = new string[]  {"0","0","0","0","0","0","0","0"};
            try
            {
                string text = Convert.ToString(Convert.ToInt32(hexByte, 16), 2);
                for (int i = 0; i < text.Length; i++)
                {
                    array[7 - i] = text.Substring(text.Length - 1 - i, 1);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return array;
        }

        /// <summary>
        ///     Подсчет контрольной суммы для массива байт, это не ANSI CRC8!
        /// </summary>
        /// <param name="inputByteArr"></param>
        /// <returns>CRC в виде HEX строки</returns>        
        private string CalcCRC_One(byte[] inputByteArr)
        {
            int num = 0;
            for (int i = 1; i < inputByteArr.Length; i++)
            {
                num += ((int)inputByteArr[i] ^ i);
            }
            string text = num.ToString("X");
            return (text.Length > 2) ? text.Substring(text.Length - 2, 2) : text;
        }

        /// <summary>
        ///     Подсчет контрольной суммы для массива байт, это не ANSI CRC8!
        /// </summary>
        /// <param name="inputByteArr"></param>
        /// <returns>CRC в виде HEX строки</returns>        
        private string CalcCRC_Two(byte[] inputByteArr)
        {
            int num = 0;
            for (int i = 0; i < inputByteArr.Length; i++)
            {
                num ^= (int)inputByteArr[i];
            }
            string text = num.ToString("X");
            return (text.Length > 2) ? text.Substring(text.Length - 2, 2) : text;
        }

        private string PrepareHexStr_1(string Parameter8)
        {
            string str = this.CalcCRC_One(this.HexStr2ByteArr("F5 " + Parameter8));
            string text = "08 F5 " + Parameter8 + " " + str;
            return this.CalcCRC_Two(this.HexStr2ByteArr(text)) + " " + text;
        }


        private string PrepareHexStr_2(string Parameter9)
        {
            string str = this.CalcCRC_One(this.HexStr2ByteArr("F5 00 " + Parameter9));
            string text = "13 F5 00 " + Parameter9 + " " + str;
            return this.CalcCRC_Two(this.HexStr2ByteArr(text)) + " " + text;
        }


        private string PrepareHexStr_3(string Parameter10)
        {
            string str = this.CalcCRC_One(this.HexStr2ByteArr("F5 01 " + Parameter10));
            string text = "13 F5 01 " + Parameter10 + " " + str;
            return this.CalcCRC_Two(this.HexStr2ByteArr(text)) + " " + text;
        }


        private string PrepareHexStr_4(string Parameter11)
        {
            string str = this.CalcCRC_One(this.HexStr2ByteArr("F5 00 " + Parameter11));
            string text = "12 F5 00 " + Parameter11 + " " + str;
            return this.CalcCRC_Two(this.HexStr2ByteArr(text)) + " " + text;
        }

        // Это похоже на функцию дешифрования строк obfuscator-а
        private string Method16(string Parameter14)
        {
            string result = "";
            try
            {
                string text = Parameter14.Substring(2, 2);
                text += Parameter14.Substring(0, 2);
                int num = Convert.ToInt32(text, 16);
                int num2 = num & 31;
                string text2 = (1 + num2).ToString();
                int num3 = (num & 480) >> 5;
                string text3 = (1 + num3).ToString();
                string text4 = (((num & 32256) >> 9) + 2000).ToString();
                result = string.Concat(new string[]
{
text4,
"-",
text3,
"-",
text2
});
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return result;
        }
    }

}
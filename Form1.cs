using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComLib;
using Microsoft.Win32;
using System.Text.RegularExpressions;

namespace Vidonn4Geek
{
    public partial class Form1 : Form
    {

        private DateTime deviceDateTime;  // время на устройстве в момент замера
        private DateTime hostDateTime;    // время на компьютере в момент замера
        private bool devTimeIsReaded = false;
        private SPLib.PersonCfg personConfig;
        private Timer updateTimeTimer; 
        private Control[,] arrAlarms;

        public Form1()
        {
            InitializeComponent();
            updateTimeTimer = new Timer();
            updateTimeTimer.Interval = 500;
            updateTimeTimer.Enabled = true;
            updateTimeTimer.Tick += new EventHandler(this.OnTimeTimer);

            // Объединяем в массив все компоненты для отображения будильников
            arrAlarms = new Control[,] {
                {cbAlarmEnable1, tbAlarmTime1, cbAlarm1Sun, cbAlarm1Mon, cbAlarm1Tue, cbAlarm1Wed, cbAlarm1Thu, cbAlarm1Fri, cbAlarm1Sat},
                {cbAlarmEnable2, tbAlarmTime2, cbAlarm2Sun, cbAlarm2Mon, cbAlarm2Tue, cbAlarm2Wed, cbAlarm2Thu, cbAlarm2Fri, cbAlarm2Sat},
                {cbAlarmEnable3, tbAlarmTime3, cbAlarm3Sun, cbAlarm3Mon, cbAlarm3Tue, cbAlarm3Wed, cbAlarm3Thu, cbAlarm3Fri, cbAlarm3Sat},
                {cbAlarmEnable4, tbAlarmTime4, cbAlarm4Sun, cbAlarm4Mon, cbAlarm4Tue, cbAlarm4Wed, cbAlarm4Thu, cbAlarm4Fri, cbAlarm4Sat},
                {cbAlarmEnable5, tbAlarmTime5, cbAlarm5Sun, cbAlarm5Mon, cbAlarm5Tue, cbAlarm5Wed, cbAlarm5Thu, cbAlarm5Fri, cbAlarm5Sat},
                {cbAlarmEnable6, tbAlarmTime6, cbAlarm6Sun, cbAlarm6Mon, cbAlarm6Tue, cbAlarm6Wed, cbAlarm6Thu, cbAlarm6Fri, cbAlarm6Sat},
                {cbAlarmEnable7, tbAlarmTime7, cbAlarm7Sun, cbAlarm7Mon, cbAlarm7Tue, cbAlarm7Wed, cbAlarm7Thu, cbAlarm7Fri, cbAlarm7Sat},
                {cbAlarmEnable8, tbAlarmTime8, cbAlarm8Sun, cbAlarm8Mon, cbAlarm8Tue, cbAlarm8Wed, cbAlarm8Thu, cbAlarm8Fri, cbAlarm8Sat}
            };

        }

        // Проверка открытых COM портов на то, висит ли там наше устройство
        private void btnCheckComPorts_Click(object sender, EventArgs e)
        {
            cbDevList.Items.Clear();

            // читаем из реестра открытые COM порты
            string name = "Hardware\\\\DeviceMap\\\\SerialComm";
            RegistryKey localMachine = Registry.LocalMachine;
            RegistryKey registryKey = localMachine.OpenSubKey(name);
            string[] portList = registryKey.GetValueNames();

            for (int i = 0; i < portList.Length; i++)
            {
                string curPort = portList[i];
                string curPortName = registryKey.GetValue(curPort).ToString();
                Convert.ToInt32(curPortName.Replace("COM", ""));   // это что, чтоб на ошибки проверить???

                SPLib sPLib = new SPLib();
                sPLib.MyPortName = curPortName;
                string corDevVers = sPLib.CheckVers();
                if (corDevVers != "")
                {
                    cbDevList.Items.Add(curPortName);
                }
                sPLib.Close();
            }

            localMachine.Close();
            registryKey.Close();

            if (cbDevList.Items.Count > 0) cbDevList.SelectedIndex = 0;
        }

        // Чтение информации об устройстве
        private void btnReadDevInfo_Click(object sender, EventArgs e)
        {
            SPLib sPLib = new SPLib();
            sPLib.MyPortName = cbDevList.Text;

            // Читаем версию прошивки
            string firmVer = sPLib.CheckVers();
            lblFirmVer.Text = firmVer;

            // Читаем название бренда 
            string brandName = sPLib.GetBand();
            lblBand.Text = brandName;

            // Читаем ID устройства 
            string devId = sPLib.GetBmac();
            lblId.Text = devId;

            sPLib.Close();
        }

        /// <summary>
        ///     Обработчик события OnTick таймера, который обновляет время
        /// </summary>
        private void OnTimeTimer(object sender, EventArgs e)
        {
            if (devTimeIsReaded && !tbTime.Focused)
            {
                DateTime timeToShow = DateTime.Now - (hostDateTime - deviceDateTime);
                tbTime.Text = timeToShow.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }

        // Получение времени на устройстве
        private void button5_Click(object sender, EventArgs e)
        {
            SPLib sPLib = new SPLib();
            sPLib.MyPortName = cbDevList.Text;

            // Читаем время
            string devDateTime = sPLib.GetTime();
            if (devDateTime == "")
            {
                MessageBox.Show("Can't read date and time from Device", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                deviceDateTime = Convert.ToDateTime(devDateTime);
                hostDateTime = DateTime.Now;
                devTimeIsReaded = true;
            }            

            sPLib.Close();
        }

        // Установка времени на устройство
        private void button4_Click(object sender, EventArgs e)
        {
            SPLib sPLib = new SPLib();
            sPLib.MyPortName = cbDevList.Text;

            Regex rgx = new Regex("\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}:\\d{2}", RegexOptions.IgnoreCase);
 
            if (!rgx.IsMatch(tbTime.Text))
            {
                MessageBox.Show("Enter date and time or use 'Sync by PC' button", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (!sPLib.SetTime(tbTime.Text)) {
                MessageBox.Show("Can't set date and time to Device", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            sPLib.Close();
        }

        // Синхронизация времени на устройстве по времени компьютера
        private void button1_Click(object sender, EventArgs e)
        {

            SPLib sPLib = new SPLib();
            sPLib.MyPortName = cbDevList.Text;


            if (!sPLib.SetTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")))
            {
                MessageBox.Show("Can't synchronize date and time to Device", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                deviceDateTime = DateTime.Now;
                hostDateTime = deviceDateTime;
            }

            sPLib.Close();

            this.button5_Click(this, null);
        }

        // Читаем персональную информацию
        private void button2_Click(object sender, EventArgs e)
        {
            SPLib sPLib = new SPLib();
            sPLib.MyPortName = cbDevList.Text;

            personConfig = sPLib.GetPersonConfig();
            tbWeight.Text = personConfig.weight.ToString();
            tbHeight.Text = personConfig.height.ToString();
            cbSex.SelectedIndex = ((personConfig.female) ? 1 : 0);
            tbAge.Text = personConfig.age.ToString();
            tbGoal.Text = personConfig.goal.ToString();

            sPLib.Close();
        }

        // Установка персональной информации
        private void button3_Click(object sender, EventArgs e)
        {
            SPLib sPLib = new SPLib();
            sPLib.MyPortName = cbDevList.Text;

            personConfig.weight = int.Parse(tbWeight.Text);
            personConfig.height = int.Parse(tbHeight.Text);
            personConfig.female = ((cbSex.SelectedIndex == 1) ? true : false);
            personConfig.age = int.Parse(tbAge.Text);
            personConfig.goal = int.Parse(tbGoal.Text);

            if (!sPLib.SetPersonConfig(personConfig))
            {
                MessageBox.Show("Can't change personal info in Device", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            sPLib.Close();
        }

        // Вспомогательная функция для делания будильника активным/неактивным
        private void setAlarmEnable(int alarmNo, bool enabled) 
        {
            for (int i = 1; i <= 8; i++)
            {
                arrAlarms[alarmNo, i].Enabled = enabled;
            }
        }

        // Чтение информации по будильникам
        private void button10_Click(object sender, EventArgs e)
        {
            // Все делаю только для GetAlarmSet, вероятно это относится к второй версии прошивки
            SPLib sPLib = new SPLib();
            sPLib.MyPortName = cbDevList.Text;
            string[,] alarmSet = sPLib.GetAlarmSet();

            for (int i = 0; i < 8; i++)
            {
                // Включен ли будильник
                bool alarmEnableValue = alarmSet[i, 1] == "1" ? true : false;
                ((CheckBox) arrAlarms[i, 0]).Checked = alarmEnableValue;
                setAlarmEnable(i, alarmEnableValue);

                // Время будильника
                string hour = "00" + Convert.ToInt32(alarmSet[i, 9]);
                hour = hour.Substring(hour.Length - 2, 2);
                string min = "00" + Convert.ToInt32(alarmSet[i, 10]);
                min = min.Substring(min.Length - 2, 2);

                ((MaskedTextBox) arrAlarms[i, 1]).Text = hour + ":" + min;


                // Дни недели
                for (int j = 2; j <= 8; j++)
                {
                    bool alarmDayValue = alarmSet[i, j] == "1" ? true : false;
                    ((CheckBox) arrAlarms[i, j]).Checked = alarmDayValue;
                }
            }
            sPLib.Close();           
        }

        // Изменени состояния будильника
        private void cbAlarmEnable_CheckedChanged(object sender, EventArgs e)
        {
            setAlarmEnable(int.Parse((string)((CheckBox)sender).Tag), ((CheckBox)sender).Checked);
        }

        // Сохранение будильников
        private void button9_Click(object sender, EventArgs e)
        {
            string[,] arrValues = new string[8, 11];

            for (int k = 0; k < 8; k++)
            {
                arrValues[k, 0] = "00";
                arrValues[k, 1] = ((CheckBox)arrAlarms[k, 0]).Checked == true ? "1" : "0";  // Enable
                arrValues[k, 2] = ((CheckBox)arrAlarms[k, 2]).Checked == true ? "1" : "0";  // San
                arrValues[k, 3] = ((CheckBox)arrAlarms[k, 3]).Checked == true ? "1" : "0";  // Mon
                arrValues[k, 4] = ((CheckBox)arrAlarms[k, 4]).Checked == true ? "1" : "0";  // Tue
                arrValues[k, 5] = ((CheckBox)arrAlarms[k, 5]).Checked == true ? "1" : "0";  // Wed
                arrValues[k, 6] = ((CheckBox)arrAlarms[k, 6]).Checked == true ? "1" : "0";  // Thu
                arrValues[k, 7] = ((CheckBox)arrAlarms[k, 7]).Checked == true ? "1" : "0";  // Fri
                arrValues[k, 8] = ((CheckBox)arrAlarms[k, 8]).Checked == true ? "1" : "0";  // Sat
                arrValues[k, 9] = ((MaskedTextBox)arrAlarms[k, 1]).Text.Substring(0, 2);    // Hour
                arrValues[k, 10] = ((MaskedTextBox)arrAlarms[k, 1]).Text.Substring(3, 2);   // Min
            }
 
            SPLib sPLib = new SPLib();
            sPLib.MyPortName = cbDevList.Text;
            sPLib.SetAlarmSet(arrValues);
            sPLib.Close();
        }

        // Получение спортивных данных, для второй версии прошивки
        private void button8_Click(object sender, EventArgs e)
        {
            tbSportData.Text = "[День] [Час] [Шагов] [Дистанция] [Калорий]\r\n";

            SPLib sPLib = new SPLib();
            sPLib.MyPortName = cbDevList.Text;

            string[,] sptdata = sPLib.getSptdata();
            for (int i = 0; i < 168; i++)
            {
                tbSportData.Text = tbSportData.Text + sptdata[i, 0] + "\t" + sptdata[i, 1] + ":00:00|" + sptdata[i, 2] + "|" + sptdata[i, 3] + "|" + sptdata[i, 4] + "|0\r\n";
            }
            sPLib.Close();
        }

        private void led_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox led = (CheckBox)sender;
            if (led.Checked)
            {
                // Отщелкним другие светодиодные кнопки
                foreach (Control control in groupBox4.Controls)
                {
                    if ((control.GetType().ToString() == "System.Windows.Forms.CheckBox") && (control.Name != led.Name))
                    {
                        ((CheckBox)control).Checked = false;
                    }
                }

                if (led.Name == "ledRed") led.BackColor = Color.Red;
                if (led.Name == "ledGreen") led.BackColor = Color.Green;
                if (led.Name == "ledBlue") led.BackColor = Color.Blue;
            }
            else
            {
                led.BackColor = SystemColors.Control;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SPLib sPLib = new SPLib();
            sPLib.MyPortName = cbDevList.Text;
            tbSportData.Text = tbSportData.Text + "\r\nВызов функции GetSitConfig(), результат:\r\n\t" + sPLib.GetSitConfig();
            sPLib.Close();            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SPLib sPLib = new SPLib();
            sPLib.MyPortName = cbDevList.Text;
            tbSportData.Text = tbSportData.Text + "\r\nВызов функции GetLed(), результат:\r\n\t" + sPLib.GetLed();
            sPLib.Close();   
        }

    }
}

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

        public Form1()
        {
            InitializeComponent();
            updateTimeTimer = new Timer();
            updateTimeTimer.Interval = 500;
            updateTimeTimer.Enabled = true;
            updateTimeTimer.Tick += new EventHandler(this.OnTimeTimer);
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

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
            string devId = sPLib.getBmac();
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
            personConfig.height = int.Parse(tbWeight.Text);
            personConfig.female = ((cbSex.SelectedIndex == 1) ? true : false);
            personConfig.age = int.Parse(tbAge.Text);
            personConfig.goal = int.Parse(tbGoal.Text);

            if (!sPLib.SetPersonConfig(personConfig))
            {
                MessageBox.Show("Can't change personal info in Device", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            sPLib.Close();
        }
    }
}

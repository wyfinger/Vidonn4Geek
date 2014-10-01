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

namespace Vidonn4Geek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}

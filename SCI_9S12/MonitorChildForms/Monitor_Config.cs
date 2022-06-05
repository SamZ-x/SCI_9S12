using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;

namespace SCI_9S12.MonitorChildForms
{
    public partial class Monitor_Config : Form
    {
        #region Declaration
        Main MainForm;
        SerialPort ActivedPort;

        #endregion

        public Monitor_Config(Main mainform)
        {
            InitializeComponent();

            //Get the serial port object of Main
            MainForm = mainform;

            #region Events
            Load += Monitor_Config_Load;
            MainForm.UpdatePortconfigEventhandler += MainForm_UpdatePortconfigEventhandler;
            #endregion
        }
        #region Event handlers

        private void MainForm_UpdatePortconfigEventhandler()
        {
            UpdatePortConfig();
        }


        private void Monitor_Config_Load(object sender, EventArgs e)
        {
                UpdatePortConfig();
        }

        private void UpdatePortConfig()
        {
            if (MainForm._newSerialPort != null && MainForm._newSerialPort.IsOpen)
            {
                lbl_portname_value.Text = MainForm._newSerialPort.PortName;
                lbl_baudrate_value.Text = MainForm._newSerialPort.BaudRate.ToString();
                lbl_databits_value.Text = MainForm._newSerialPort.DataBits.ToString();
                lbl_parity_value.Text = MainForm._newSerialPort.Parity.ToString();
                lbl_stopbits_value.Text = MainForm._newSerialPort.StopBits.ToString();
                lbl_status_value.Text =  "Connected";
            }
            else 
            {
                lbl_portname_value.Text = "N/A";
                lbl_baudrate_value.Text = "N/A";
                lbl_databits_value.Text = "N/A";
                lbl_parity_value.Text = "N/A";
                lbl_stopbits_value.Text = "N/A";
                lbl_status_value.Text = "Disconnected";
            }
        }
        #endregion
    }
}

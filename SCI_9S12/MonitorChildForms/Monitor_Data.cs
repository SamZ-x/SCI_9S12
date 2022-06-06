using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCI_9S12.MonitorChildForms
{
    public partial class Monitor_Data : Form
    {
        #region Declaration

        Main MainForm;
        bool IsReady = false;
        
        #endregion

        public Monitor_Data(Main mainform)
        {
            InitializeComponent();

            //Get the serial port object of Main
            MainForm = mainform;

            #region Events
            Load += Monitor_Data_Load;
            MainForm.UpdateReceivedDataEventhandler += MainForm_UpdateReceivedDataEventhandler;
            
            #endregion
        }

        private void MainForm_UpdateReceivedDataEventhandler()
        {
            UpdateReceivedData();
        }

        private void Monitor_Data_Load(object sender, EventArgs e)
        {
            UpdateReceivedData();
        }

        private void UpdateReceivedData()
        {
            if (IsHandleCreated) 
            {
                if (MainForm.CurrentSerialPortPackage.DataList.Count != 0)
                {
                    string NewData = MainForm.CurrentSerialPortPackage.DataList[MainForm.CurrentSerialPortPackage.DataList.Count - 1];
                    Invoke(new Action(() => { txt_livedata.Text = NewData; }));

                    Invoke(new Action(() => {
                        richTextBox1.Text = "";
                        for (int i = 0; i < MainForm.CurrentSerialPortPackage.DataList.Count; ++i)
                            richTextBox1.Text += $"{MainForm.CurrentSerialPortPackage.DataList[i]}\n"; 
                    }));
                }
            }
        }
    }
}

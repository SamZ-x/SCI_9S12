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


        #region Event handlers
        /// <summary>
        /// Initialization
        /// </summary>
        private void Monitor_Data_Load(object sender, EventArgs e)
        {
            UpdateReceivedData();
        }

        /// <summary>
        /// Update the data view when receive data
        /// </summary>
        private void MainForm_UpdateReceivedDataEventhandler()
        {
            UpdateReceivedData();
        }

        #endregion

        #region Hepler Methods
        /// <summary>
        /// Update the live data and history data control
        /// </summary>
        private void UpdateReceivedData()
        {
            //check control ready before invoking, otherwise throw exception
            if (IsHandleCreated) 
            {
                int DatalistCount = MainForm.CurrentSerialPortPackage.DataList.Count;
                if (DatalistCount != 0)
                {
                    string NewData = MainForm.CurrentSerialPortPackage.DataList[DatalistCount - 1];
                    Invoke(new Action(() =>
                    {
                        txt_livedata.Text = NewData;
                        listBox_historydata.Items.Clear();
                        for (int i = 0; i < DatalistCount; ++i)
                            listBox_historydata.Items.Insert(0, MainForm.CurrentSerialPortPackage.DataList[i]);
                    }));
                }
            }
        }
        #endregion
    }
}

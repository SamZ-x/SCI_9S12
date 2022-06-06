using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SCI_9S12
{
    public partial class Monitor : Form
    {
        #region declaration
        
        Button ActivedButton = null;    //store current button
        Form ActivedForm = null;        //store current functional form
        Main MainForm = null;
        int FormGap = 10;
       
        #endregion

        /// <summary>
        /// Create monitor instance
        /// </summary>
        /// <param name="main">Main form reference</param>
        public Monitor(Main main)
        {
            InitializeComponent();

            //get the main form reference
            MainForm = main;

            #region Event

            Load += Monitor_Load;
            menu_exit.Click += Menu_exit_Click;
            menuStrip_menu.MouseDown += MenuStrip_menu_MouseDown1;
            btn_data.Click += Btn_data_Click;
            btn_config.Click += Btn_config_Click;

            #endregion
        }


        #region Event handlers

        /// <summary>
        /// Initialize the monitor UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Monitor_Load(object sender, EventArgs e)
        {
            Location = new Point(MainForm.Location.X + MainForm.Width + FormGap, MainForm.Location.Y);
            ActiveSectionButton(btn_data);
            ActiveSectionPanel(new MonitorChildForms.Monitor_Data());
        }

        /// <summary>
        /// Active the live data panel
        /// </summary>
        private void Btn_data_Click(object sender, EventArgs e)
        {
            ActiveSectionButton(btn_data);
            ActiveSectionPanel(new MonitorChildForms.Monitor_Data());
        }

        /// <summary>
        /// Display the configure panel
        /// </summary>
        private void Btn_config_Click(object sender, EventArgs e)
        {
            ActiveSectionButton(btn_config);
            ActiveSectionPanel(new MonitorChildForms.Monitor_Config(MainForm));
        }

        /// <summary>
        /// Close the monitor
        /// </summary>
        private void Menu_exit_Click(object sender, EventArgs e)
        {
            MainForm.Monitor_Page = null;
            Close();
        }

        #endregion


        #region Helper Methods

        /// <summary>
        /// Active the current button and deacive the pervious button 
        /// </summary>
        /// <param name="sectionbutton">Current section button</param>
        private void ActiveSectionButton(Button sectionbutton)
        {
            DactiveSectionButton(ActivedButton);
            ActivedButton = sectionbutton;
            ActivedButton.BackColor = SystemColors.Highlight;
        }

        private void DactiveSectionButton(Button sectionbutton)
        {
            if (sectionbutton != null)
                sectionbutton.BackColor = SystemColors.AppWorkspace;
        }

        /// <summary>
        /// Display the actived form on section panel
        /// </summary>
        /// <param name="monitor_childform">Traget child form</param>
        private void ActiveSectionPanel(Form monitor_childform)
        {
            if (ActivedForm != null)
                ActivedForm.Close();

            ActivedForm = monitor_childform;

            //set the properties of the form
            ActivedForm.Dock = DockStyle.Fill;                        //fill the whole panel
            ActivedForm.FormBorderStyle = FormBorderStyle.None;       //make the border invisible
            ActivedForm.TopLevel = false;

            panel_sections.Controls.Add(ActivedForm);                  //add child form
            panel_sections.Tag = ActivedForm;
            ActivedForm.BringToFront();                               //make sure the child form at the front
            ActivedForm.Show();
        }

        #endregion

        #region UI control

        /// <summary>
        /// implement function to dray the window
        /// </summary>
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        /// <summary>
        /// when the mouse over the panel and press, dray the window
        /// </summary>
        private void MenuStrip_menu_MouseDown1(object sender, MouseEventArgs e)
        {
            //call the methods
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion
    }
}

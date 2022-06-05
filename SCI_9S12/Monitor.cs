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
        public Monitor()
        {
            InitializeComponent();

            #region Event

            menu_exit.Click += Menu_exit_Click;
            menuStrip_menu.MouseDown += MenuStrip_menu_MouseDown1;
            #endregion
        }



        private void Menu_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

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

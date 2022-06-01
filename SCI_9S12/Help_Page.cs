using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCI_9S12
{
    public partial class Help_Page : Form
    {
        public Help_Page()
        {
            InitializeComponent();

            #region Event
            btn_exit.Click += Btn_exit_Click;
            #endregion
        }

        #region Event
        /// <summary>
        /// Close the current window
        /// </summary>

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}

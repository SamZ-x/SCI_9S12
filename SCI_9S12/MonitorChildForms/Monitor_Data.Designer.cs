
namespace SCI_9S12.MonitorChildForms
{
    partial class Monitor_Data
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_portname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_livedata = new System.Windows.Forms.TextBox();
            this.listBox_historydata = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_portname
            // 
            this.lbl_portname.AutoSize = true;
            this.lbl_portname.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_portname.Location = new System.Drawing.Point(12, 9);
            this.lbl_portname.Name = "lbl_portname";
            this.lbl_portname.Size = new System.Drawing.Size(97, 25);
            this.lbl_portname.TabIndex = 3;
            this.lbl_portname.Text = "Live Data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "History Data (20 Recectly Records) :";
            // 
            // txt_livedata
            // 
            this.txt_livedata.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_livedata.Location = new System.Drawing.Point(16, 44);
            this.txt_livedata.Name = "txt_livedata";
            this.txt_livedata.ReadOnly = true;
            this.txt_livedata.Size = new System.Drawing.Size(290, 25);
            this.txt_livedata.TabIndex = 5;
            // 
            // listBox_historydata
            // 
            this.listBox_historydata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_historydata.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_historydata.FormattingEnabled = true;
            this.listBox_historydata.ItemHeight = 21;
            this.listBox_historydata.Location = new System.Drawing.Point(337, 44);
            this.listBox_historydata.Name = "listBox_historydata";
            this.listBox_historydata.ScrollAlwaysVisible = true;
            this.listBox_historydata.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox_historydata.Size = new System.Drawing.Size(451, 338);
            this.listBox_historydata.TabIndex = 7;
            // 
            // Monitor_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.listBox_historydata);
            this.Controls.Add(this.txt_livedata);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_portname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Monitor_Data";
            this.Text = "Monitor_Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_portname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_livedata;
        private System.Windows.Forms.ListBox listBox_historydata;
    }
}
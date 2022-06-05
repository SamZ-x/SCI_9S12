
namespace SCI_9S12.MonitorChildForms
{
    partial class Monitor_Config
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
            this.groupBox_portconfig = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_portname = new System.Windows.Forms.Label();
            this.lbl_baudrate = new System.Windows.Forms.Label();
            this.lbl_parity = new System.Windows.Forms.Label();
            this.lbl_databits = new System.Windows.Forms.Label();
            this.lbl_stopbits = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_portname_value = new System.Windows.Forms.Label();
            this.lbl_parity_value = new System.Windows.Forms.Label();
            this.lbl_stopbits_value = new System.Windows.Forms.Label();
            this.lbl_baudrate_value = new System.Windows.Forms.Label();
            this.lbl_status_value = new System.Windows.Forms.Label();
            this.lbl_databits_value = new System.Windows.Forms.Label();
            this.groupBox_portconfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_portconfig
            // 
            this.groupBox_portconfig.Controls.Add(this.lbl_databits_value);
            this.groupBox_portconfig.Controls.Add(this.lbl_status_value);
            this.groupBox_portconfig.Controls.Add(this.lbl_baudrate_value);
            this.groupBox_portconfig.Controls.Add(this.lbl_stopbits_value);
            this.groupBox_portconfig.Controls.Add(this.lbl_parity_value);
            this.groupBox_portconfig.Controls.Add(this.lbl_portname_value);
            this.groupBox_portconfig.Controls.Add(this.lbl_status);
            this.groupBox_portconfig.Controls.Add(this.lbl_stopbits);
            this.groupBox_portconfig.Controls.Add(this.lbl_databits);
            this.groupBox_portconfig.Controls.Add(this.lbl_parity);
            this.groupBox_portconfig.Controls.Add(this.lbl_baudrate);
            this.groupBox_portconfig.Controls.Add(this.lbl_portname);
            this.groupBox_portconfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_portconfig.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_portconfig.Location = new System.Drawing.Point(0, 0);
            this.groupBox_portconfig.Name = "groupBox_portconfig";
            this.groupBox_portconfig.Size = new System.Drawing.Size(800, 114);
            this.groupBox_portconfig.TabIndex = 0;
            this.groupBox_portconfig.TabStop = false;
            this.groupBox_portconfig.Text = "Port Configure";
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 127);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output Configure";
            // 
            // lbl_portname
            // 
            this.lbl_portname.AutoSize = true;
            this.lbl_portname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_portname.Location = new System.Drawing.Point(6, 25);
            this.lbl_portname.Name = "lbl_portname";
            this.lbl_portname.Size = new System.Drawing.Size(87, 21);
            this.lbl_portname.TabIndex = 0;
            this.lbl_portname.Text = "Port Name:";
            // 
            // lbl_baudrate
            // 
            this.lbl_baudrate.AutoSize = true;
            this.lbl_baudrate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_baudrate.Location = new System.Drawing.Point(247, 51);
            this.lbl_baudrate.Name = "lbl_baudrate";
            this.lbl_baudrate.Size = new System.Drawing.Size(83, 21);
            this.lbl_baudrate.TabIndex = 1;
            this.lbl_baudrate.Text = "Baud Rate:";
            // 
            // lbl_parity
            // 
            this.lbl_parity.AutoSize = true;
            this.lbl_parity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parity.Location = new System.Drawing.Point(6, 51);
            this.lbl_parity.Name = "lbl_parity";
            this.lbl_parity.Size = new System.Drawing.Size(52, 21);
            this.lbl_parity.TabIndex = 2;
            this.lbl_parity.Text = "Parity:";
            // 
            // lbl_databits
            // 
            this.lbl_databits.AutoSize = true;
            this.lbl_databits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_databits.Location = new System.Drawing.Point(519, 51);
            this.lbl_databits.Name = "lbl_databits";
            this.lbl_databits.Size = new System.Drawing.Size(70, 21);
            this.lbl_databits.TabIndex = 3;
            this.lbl_databits.Text = "DataBits:";
            // 
            // lbl_stopbits
            // 
            this.lbl_stopbits.AutoSize = true;
            this.lbl_stopbits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stopbits.Location = new System.Drawing.Point(6, 77);
            this.lbl_stopbits.Name = "lbl_stopbits";
            this.lbl_stopbits.Size = new System.Drawing.Size(69, 21);
            this.lbl_stopbits.TabIndex = 4;
            this.lbl_stopbits.Text = "StopBits:";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(252, 77);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(55, 21);
            this.lbl_status.TabIndex = 5;
            this.lbl_status.Text = "Status:";
            // 
            // lbl_portname_value
            // 
            this.lbl_portname_value.AutoSize = true;
            this.lbl_portname_value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_portname_value.Location = new System.Drawing.Point(109, 25);
            this.lbl_portname_value.Name = "lbl_portname_value";
            this.lbl_portname_value.Size = new System.Drawing.Size(52, 21);
            this.lbl_portname_value.TabIndex = 6;
            this.lbl_portname_value.Text = "Parity:";
            // 
            // lbl_parity_value
            // 
            this.lbl_parity_value.AutoSize = true;
            this.lbl_parity_value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parity_value.Location = new System.Drawing.Point(109, 51);
            this.lbl_parity_value.Name = "lbl_parity_value";
            this.lbl_parity_value.Size = new System.Drawing.Size(52, 21);
            this.lbl_parity_value.TabIndex = 7;
            this.lbl_parity_value.Text = "Parity:";
            // 
            // lbl_stopbits_value
            // 
            this.lbl_stopbits_value.AutoSize = true;
            this.lbl_stopbits_value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stopbits_value.Location = new System.Drawing.Point(109, 77);
            this.lbl_stopbits_value.Name = "lbl_stopbits_value";
            this.lbl_stopbits_value.Size = new System.Drawing.Size(52, 21);
            this.lbl_stopbits_value.TabIndex = 8;
            this.lbl_stopbits_value.Text = "Parity:";
            // 
            // lbl_baudrate_value
            // 
            this.lbl_baudrate_value.AutoSize = true;
            this.lbl_baudrate_value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_baudrate_value.Location = new System.Drawing.Point(362, 51);
            this.lbl_baudrate_value.Name = "lbl_baudrate_value";
            this.lbl_baudrate_value.Size = new System.Drawing.Size(52, 21);
            this.lbl_baudrate_value.TabIndex = 9;
            this.lbl_baudrate_value.Text = "Parity:";
            // 
            // lbl_status_value
            // 
            this.lbl_status_value.AutoSize = true;
            this.lbl_status_value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status_value.Location = new System.Drawing.Point(362, 77);
            this.lbl_status_value.Name = "lbl_status_value";
            this.lbl_status_value.Size = new System.Drawing.Size(52, 21);
            this.lbl_status_value.TabIndex = 10;
            this.lbl_status_value.Text = "Parity:";
            // 
            // lbl_databits_value
            // 
            this.lbl_databits_value.AutoSize = true;
            this.lbl_databits_value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_databits_value.Location = new System.Drawing.Point(595, 51);
            this.lbl_databits_value.Name = "lbl_databits_value";
            this.lbl_databits_value.Size = new System.Drawing.Size(52, 21);
            this.lbl_databits_value.TabIndex = 11;
            this.lbl_databits_value.Text = "Parity:";
            // 
            // Monitor_Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_portconfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Monitor_Config";
            this.Text = "Monitor_Config";
            this.groupBox_portconfig.ResumeLayout(false);
            this.groupBox_portconfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_portconfig;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_stopbits;
        private System.Windows.Forms.Label lbl_databits;
        private System.Windows.Forms.Label lbl_parity;
        private System.Windows.Forms.Label lbl_baudrate;
        private System.Windows.Forms.Label lbl_portname;
        private System.Windows.Forms.Label lbl_portname_value;
        private System.Windows.Forms.Label lbl_parity_value;
        private System.Windows.Forms.Label lbl_stopbits_value;
        private System.Windows.Forms.Label lbl_baudrate_value;
        private System.Windows.Forms.Label lbl_status_value;
        private System.Windows.Forms.Label lbl_databits_value;
    }
}
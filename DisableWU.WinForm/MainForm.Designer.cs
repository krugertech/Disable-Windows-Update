namespace DisableWU.WinForm
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnDisableWindowsUpdate = new System.Windows.Forms.Button();
            this.btnEnableWindowsUpdate = new System.Windows.Forms.Button();
            this.serviceDisableWindowsUpdate = new System.ServiceProcess.ServiceController();
            this.lblStatus = new System.Windows.Forms.Label();
            this.serviceWindowsUpdate = new System.ServiceProcess.ServiceController();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnDisableWindowsUpdate
            // 
            this.btnDisableWindowsUpdate.Location = new System.Drawing.Point(56, 91);
            this.btnDisableWindowsUpdate.Name = "btnDisableWindowsUpdate";
            this.btnDisableWindowsUpdate.Size = new System.Drawing.Size(165, 23);
            this.btnDisableWindowsUpdate.TabIndex = 0;
            this.btnDisableWindowsUpdate.Text = "Disable Windows Update";
            this.btnDisableWindowsUpdate.UseVisualStyleBackColor = true;
            this.btnDisableWindowsUpdate.Click += new System.EventHandler(this.btnDisableWindowsUpdate_Click);
            // 
            // btnEnableWindowsUpdate
            // 
            this.btnEnableWindowsUpdate.Location = new System.Drawing.Point(56, 120);
            this.btnEnableWindowsUpdate.Name = "btnEnableWindowsUpdate";
            this.btnEnableWindowsUpdate.Size = new System.Drawing.Size(165, 23);
            this.btnEnableWindowsUpdate.TabIndex = 1;
            this.btnEnableWindowsUpdate.Text = "Enable Windows Update";
            this.btnEnableWindowsUpdate.UseVisualStyleBackColor = true;
            this.btnEnableWindowsUpdate.Click += new System.EventHandler(this.btnEnableWindowsUpdate_Click);
            // 
            // serviceDisableWindowsUpdate
            // 
            this.serviceDisableWindowsUpdate.ServiceName = "Disable Windows Update";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(36, 39);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(184, 16);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Windows Update Status: .........";
            // 
            // serviceWindowsUpdate
            // 
            this.serviceWindowsUpdate.ServiceName = "wuauserv";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 158);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnEnableWindowsUpdate);
            this.Controls.Add(this.btnDisableWindowsUpdate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disable Windows Update";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisableWindowsUpdate;
        private System.Windows.Forms.Button btnEnableWindowsUpdate;
        private System.ServiceProcess.ServiceController serviceDisableWindowsUpdate;
        private System.Windows.Forms.Label lblStatus;
        private System.ServiceProcess.ServiceController serviceWindowsUpdate;
        private System.Windows.Forms.Timer timer1;
    }
}
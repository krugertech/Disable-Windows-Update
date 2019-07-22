using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisableWU.WinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDisableWindowsUpdate_Click(object sender, EventArgs e)
        {
            
            try
            {
                serviceDisableWindowsUpdate.Start();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void btnEnableWindowsUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                serviceDisableWindowsUpdate.Stop();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            try
            {
                this.EnableWindowsUpdateService();
                serviceWindowsUpdate.Start();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {        
        }

        private void RefreshStatus()
        {
            try
            {
                serviceWindowsUpdate.Refresh();

                if (serviceWindowsUpdate.Status == ServiceControllerStatus.Running)
                {
                    lblStatus.Text = "Windows Update Status: Running";
                }
                else if (serviceWindowsUpdate.StartType == ServiceStartMode.Disabled)
                {
                    lblStatus.Text = "Windows Update Status: Disabled";
                }
                else if (serviceWindowsUpdate.Status == ServiceControllerStatus.Stopped)
                {
                    lblStatus.Text = "Windows Update Status: Active";
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RefreshStatus();
        }        

        private void EnableWindowsUpdateService()
        {
            using (var mo = new ManagementObject($"Win32_Service.Name=\"wuauserv\""))
            {
                mo.InvokeMethod("ChangeStartMode", new object[] { "Automatic" });
            }
        }
}
}

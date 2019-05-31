using System.Diagnostics;

namespace Windows.Service
{
    sealed partial class StatusService
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // 
            // StatusService
            // 
            this.AutoLog = false;
            this.ServiceName = Global.ServiceName;            
        }

        private string CreateEventSource(string currentAppName)
        {
            string eventSource = currentAppName;            
            try
            {               
                if (!EventLog.SourceExists(eventSource))
                {  
                    // no exception until yet means the user as admin privilege
                    System.Diagnostics.EventLog.CreateEventSource(eventSource, "Application");
                }
            }
            catch (System.Security.SecurityException)
            {                
            }

            return eventSource;
        }
        #endregion
    }
}

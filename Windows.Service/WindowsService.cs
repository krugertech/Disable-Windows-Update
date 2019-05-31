using System;
using System.Diagnostics;
using System.ServiceProcess;
using System.Threading;
using System.Threading.Tasks;

namespace Windows.Service
{
    public partial class StatusService : ServiceBase
    {
        public StatusService()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                this.EventLog.WriteEntry("Error initializing service. " + ex.Message, EventLogEntryType.Error);
            }
        }

        public void Start()
        {
            try
            {               
                Global.EventLog = this.EventLog;                               

                // Run worker
                Task.Run(() =>
                {
                    while (Global.CancellationFlagSet != true)
                    {
                        Global.Report("Checking service status...");

                        try
                        {
                            WindowsUpdate windowsUpdate = new WindowsUpdate();
                            if (windowsUpdate.IsRunning() || !windowsUpdate.IsDisabled())
                            {
                                Global.Report("Service active. Stopping and disabling.");
                                windowsUpdate.StopAndDisable();
                            }
                        }
                        catch (Exception ex)
                        {
                            Global.Report(ex.Message);
                            if (ex.InnerException != null)
                                Global.Report(ex.InnerException.Message);
                        }

                        Thread.Sleep(new TimeSpan(0, 0, 0, 5));
                    }
                });

                this.EventLog.WriteEntry("Exitting service.", EventLogEntryType.Information);
            }
            catch (Exception ex)
            {
                try
                {
                    Global.Report("Error starting service. " + ex.Message);
                    this.EventLog.WriteEntry("Error starting service. " + ex.Message, EventLogEntryType.Error);
                } catch { }                   
            }
        }        

        public new void Stop()
        {
            Global.CancellationFlagSet = true;            
            base.Stop();
        }

        protected override void OnStart(string[] args)
        {
#if DEBUG
            base.RequestAdditionalTime(600000); // 10 minutes timeout for startup
            Debugger.Launch(); // launch and attach debugger
#endif
            
            this.EventLog.WriteEntry("Service start request received.", EventLogEntryType.Information);
            this.Start();
            base.OnStart(args);
        }

        protected override void OnStop()
        {
            Global.CancellationFlagSet = true;
            this.EventLog.WriteEntry("Service stop request received.", EventLogEntryType.Information);
            this.EventLog.Dispose();
        }
    }
}

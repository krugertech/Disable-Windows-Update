using System;
using System.ServiceProcess;
using System.Threading;

namespace Windows.Service
{
    public class WindowsUpdate
    {
        private const string SERVICENAME = "Windows Update";
        private ServiceController _windowsUpdate;

        public WindowsUpdate()
        {
            try
            {
                _windowsUpdate = new ServiceController(SERVICENAME);
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting the Windows Update service.", ex);                
            }
        }

        public void StopAndDisable()
        {             
            if (_windowsUpdate == null)
            {
                return;
            }

            try
            {
                if (this.IsRunning())
                {
                    _windowsUpdate.Stop();
                }

                if (!this.IsDisabled())
                {
                    ServiceHelper.ModifyStartMode(_windowsUpdate, ServiceStartMode.Disabled);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error stopping and disabling the Windows Update service.", ex);
            }
        }

        public bool IsRunning()
        {
            ServiceControllerStatus status;
            uint counter = 0;
            do
            {
                status = _windowsUpdate.Status;
                Thread.Sleep(100);
            } while (!(status == ServiceControllerStatus.Stopped ||
                       status == ServiceControllerStatus.Running) &&
                     (++counter < 100));
            return status == ServiceControllerStatus.Running;
        }

        public bool IsDisabled()
        {
            return _windowsUpdate.StartType == ServiceStartMode.Disabled;
        }
    }
}



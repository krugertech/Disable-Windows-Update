using System.ComponentModel;

namespace Windows.Service
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            this.Installers.Clear();
            InitializeComponent();
        }

        private void serviceInstaller1_AfterInstall(object sender, System.Configuration.Install.InstallEventArgs e)
        {
            using (System.ServiceProcess.ServiceController sc = new
                System.ServiceProcess.ServiceController(serviceInstaller1.ServiceName))
            {
                sc.Start();
            }
        }
    }
}

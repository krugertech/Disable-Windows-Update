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
    }
}

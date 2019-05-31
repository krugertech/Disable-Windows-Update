using System;
using System.ServiceProcess;

namespace Windows.Service
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            if (Environment.UserInteractive)
            {
                string heading = "Disable Windows Update - Service v1.0";
                System.Console.WriteLine(heading);
                Console.WindowWidth = 120;
                Console.WindowHeight = 63;

                var sync = new StatusService();
                sync.Start();
                Console.WriteLine("Press enter to exit.");
                Console.ReadLine();
                sync.Stop();
            }
            else
            {
                ServiceBase[] ServicesToRun;

                // More than one user Service may run within the same process. To add
                // another service to this process, change the following line to
                // create a second service object. For example,
                //
                //   ServicesToRun = new ServiceBase[] {new Service1(), new MySecondUserService()};
                //
                ServicesToRun = new ServiceBase[] { new StatusService() };
                ServiceBase.Run(ServicesToRun);
            }
        }
    }
}

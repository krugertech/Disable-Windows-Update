using System;
using System.Diagnostics;

namespace Windows.Service
{
    public static class Global
    {
        public static EventLog EventLog { get; set; }

        public static bool CancellationFlagSet { get; set; }
          
        public static string ServiceName => "Disable Windows Update";

        public static void Report(string msg)
        {
            if (Environment.UserInteractive)
                Console.WriteLine(msg);

            try
            {
                Debug.WriteLine(msg);
            }
            catch
            {
                try
                {
                    EventLog.WriteEntry(msg, EventLogEntryType.Information);
                }
                catch
                {
                    // Optionally write to event log.
                }
            }
        }

    }
}

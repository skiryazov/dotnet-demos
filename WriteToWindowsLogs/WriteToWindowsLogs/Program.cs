using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WriteToWindowsLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteToApplicationLog();
            WriteToCustomSource();
        }

        static void WriteToApplicationLog()
        {
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "Application";
                eventLog.WriteEntry("Works!!!", EventLogEntryType.Warning, 101, 1);
            }
        }

        static void WriteToCustomSource()
        {
            string source = "WriteToLogDemo";
            using (EventLog applicationLog = new EventLog("Application"))
            { 
                if (!EventLog.SourceExists(source))
                {
                    EventLog.CreateEventSource(source, "Application");
                }
                applicationLog.Source = source;
                applicationLog.WriteEntry("Works with custom source", 
                    EventLogEntryType.Warning, 101, 1);
            }
        }
    }
}

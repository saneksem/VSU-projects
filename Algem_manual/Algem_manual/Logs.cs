using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algem_manual
{
    static class Logs
    {
        public static void InitLogging()
        {
            string LogPath = Path.Combine(DirectoriesSettings.LogsPath, String.Format("{0:dd-MM-yy_HH-mm}.log", DateTime.Now));
            FileStream hlogFile = new FileStream(LogPath, FileMode.OpenOrCreate, FileAccess.Write);
            Trace.Listeners.Add(new TextWriterTraceListener(hlogFile));
            Trace.AutoFlush = true;
        }

        public static void Write(string message)
        {
            Trace.Write(message);
        }

        public static void WriteLine(string message)
        {
            Trace.WriteLine(message);
        }

        public static void WriteException(Exception ex)
        {
            WriteLine("Исключение: " + ex.Message);
            WriteLine(ex.ToString());
        }
    }
}

using System.Diagnostics;

namespace LunchApp.IO
{
    public class Reboot
    {
        public static void Restart()
        {
            StartShutdown("-f -r -t 5");
        }
        public static void LogOff()
        {
            StartShutdown("-l");
        }

        public static void Shut()
        {
            Restart();
        }

        public static void RestartForce()
        {
            StartShutdown("-r -f");
        }

        private static void StartShutdown(string param)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.FileName = "shutdown";
            proc.WindowStyle = ProcessWindowStyle.Hidden;
            proc.Arguments = param;
            Process.Start(proc);
        }
    }
}

namespace LunchApp.IO
{
    public class Logger : Fichier
    {
        //private FileStream? _stream;
        private String _format = "{0} - {1,2:D2}{2,2:D2}{3,2:D2}.log";
        private String _logging = "{0} - {1,2:D2}/{2,2:D2}/{3,2:D2} - {4} - {5}";
        private String _appName = String.Empty;

        public Logger(String appName)
        {
            _appName = appName;
            String filename = BuildFilename(_appName);
            CompleteFilename = Directory.GetCurrentDirectory() + "\\" + filename;
            Open();
        }

        public long AddLogging(String message, String status)
        {
            WriteLine(BuildLoggingMessage(message, status));
            return 0;
        }

        private String BuildLoggingMessage(String message, String status)
        {
            String ret = String.Empty;
            ret += String.Format(_logging, _appName, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, message, status);
            return ret;
        }
        private String BuildFilename(String appName)
        {
            String ret = String.Empty;
            
            // AppName - AAMMJJ.log
            ret += String.Format(_format, appName, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            return ret;
        }
    }
}

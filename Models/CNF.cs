namespace LunchApp.Models
{
    public class CNF
    {
        public String FileServer { get; set; } = String.Empty;
        public List<Installation> Installation { get; set; } = new List<Installation>();
}

public class Installation
    {
        public UInt16 ID { get; set; } = 0;
        public Boolean IsRunning { get; set; } = false;
        public UInt16 NbReboot { get; set; } = 0;
        public String WaitOnReboot { get; set; } = String.Empty;
        public UInt16 NbRebootDone { get; set; } = 0;
        public Boolean InstallationDone { get; set; } = false;
        public String SourcePath { get; set; } = String.Empty;
        public String SourceFilename { get; set; } = String.Empty;
    }
}

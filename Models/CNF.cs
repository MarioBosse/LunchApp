namespace LunchApp.Models
{
    public class CNF
    {
        public UInt16 ID { get; set; } = 0;
        public Boolean IsRunning { get; set; } = false;
        public UInt16 NbReboot { get; set; } = 0;
        public UInt16 NbRebootDone { get; set; } = 0;
        public Boolean InstallationDone { get; set; } = false;
        public String Path { get; set; } = String.Empty;
        public String Programm { get; set; } = String.Empty;
    }
}

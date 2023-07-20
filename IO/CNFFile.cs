using LunchApp.Models;
using LunchApp.UserControls.UCLunchAppConfigurator;
using Newtonsoft.Json;
using System.Text;

namespace LunchApp.IO
{
    public partial class CNFFile : Fichier
    {
        public String Pathname { get;private set; } = String.Empty;
        public String CnfFilename { get; private set; } = String.Empty;
        public String RootPath { get; private set; } = String.Empty;
        public CNF CNF { get; private set; } = new CNF();
        public String _filename { get; private set; } = String.Empty;
        public UInt16 NbProgress { get; private set; }

        public CNFFile(String filename)
        {
            NbProgress = 0;
            _filename = BuildFilename(filename);
            CompleteFilename = Directory.GetCurrentDirectory() + "\\" + filename;
            Open();
            ReadConfig();
        }
        private String BuildFilename(String namefile)
        {
            String ret = String.Empty;
            namefile = (namefile.Split('.'))[0];
            namefile += "cnf";

            return namefile;
        }
        private void ReadConfig()
        {
            //string content = ReadAll();
            var content = File.ReadAllText(CompleteFilename);
            var result = JsonConvert.DeserializeObject<CNF>(content);


            if (result == null) return;

            CNF.Installation.Clear();
            NbProgress = 0;

            if (result.Installation.Count > 0)
            {
                Pathname = result.FileServer;
                if (result.Installation.Count > 0)
                {
                    foreach (Installation inst in result.Installation)
                    {
                        CNF.Installation.Add(new Installation()
                        {
                            ID = inst.ID,
                            IsRunning = inst.IsRunning,
                            NbReboot = inst.NbReboot,
                            NbRebootDone = inst.NbReboot,
                            InstallationDone = inst.InstallationDone,
                            SourcePath = inst.SourcePath,
                            SourceFilename = inst.SourceFilename,
                            WaitOnReboot = inst.WaitOnReboot
                        });
                        NbProgress += (UInt16)(CNF.Installation[^1].NbReboot + 1);
                    }
                }
            }
        }
        public void SetPathName(String path)
        {
            Pathname = path;
            WriteConfig();
        }

        private void WriteConfig()
        {
            //String toWrite = "";
            //toWrite += Pathname + '\n';
            //toWrite += Header + '\n';
            //foreach(CNF cnf in CNF)
            //{
            //    toWrite += String.Format(_format, cnf.ID, cnf.IsRunning, cnf.NbReboot, cnf.NbRebootDone, cnf.InstallationDone, cnf.Path, cnf.Programm);
            //    toWrite += "\n";
            //}
            //toWrite.Append<char>((char)0x1a);
            //WriteFile(toWrite);
            Close();
            Open();
            ReadConfig();
        }
        public void BuildCNF(Control.ControlCollection controls)
        {
            UInt16 posID = 1;
            //CNF.Installations .Clear();
            foreach (FormLunchAppConfigurator control in controls)
            {
                //CNF.Installations.Add(new Installation { ID = posID++,
                //                  IsRunning = control.IsRunning,
                //                  NbReboot = Convert.ToUInt16(control.numericUpDownNbReboot.Value),
                //                  NbRebootDone = control.NbRebootDone,
                //                  InstallationDone = (control.checkBoxInstallationState.CheckState == CheckState.Indeterminate ||
                //                                     (control.checkBoxInstallationState.CheckState == CheckState.Unchecked) ? false : true),
                //                  SourcePath = control.textBoxProgramPath.Text,
                //                  SourceFilename = control.textBoxProgramToLunch.Text});
            }
            WriteConfig();
        }
    }
}

using LunchApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UCLunchAppConfigurator;
using static System.Windows.Forms.DataFormats;

namespace LunchApp.IO
{
    public partial class CNFFile : Fichier
    {
        public String Pathname { get;private set; } = String.Empty;
        private String Header = "ID,IsRunning,NbReboot,NbRebootDone,InstallationDone,InstallationPath,Program2Execute";
        private String _format = "{0,2},{1,9},{2,8},{3,12},{4,16},{5},{6}";
        public String CnfFilename { get; private set; } = String.Empty;
        public String RootPath { get; private set; } = String.Empty;
        public List<CNF> CNF { get; private set; } = new List<CNF>();
        public String _filename { get; private set; } = String.Empty;
        public CNFFile(String filename)
        {
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
            List<String> result = Encoding.ASCII.GetString(ReadAll()).Split('\n').ToList();
            if(result.Count >= 3)
            {
                Pathname = result[0];
                if (result[2].Length > 0)
                {
                    for (int i = 2; i < result.Count - 1; i++)
                    {
                        String[] cnf = result[i].Split(',');
                        CNF.Add(new CNF()
                        {
                            ID = Convert.ToUInt16(cnf[0]),
                            IsRunning = Convert.ToBoolean(cnf[1]),
                            NbReboot = Convert.ToUInt16(cnf[2]),
                            NbRebootDone = Convert.ToUInt16(cnf[3]),
                            InstallationDone = Convert.ToBoolean(cnf[4]),
                            Path = cnf[5],
                            Programm = cnf[6]
                        });
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
            String toWrite = "";
            toWrite += Pathname + '\n';
            toWrite += Header + '\n';
            foreach(CNF cnf in CNF)
            {
                toWrite += String.Format(_format, cnf.ID, cnf.IsRunning, cnf.NbReboot, cnf.NbRebootDone, cnf.InstallationDone, cnf.Path, cnf.Programm);
                toWrite += "\n";
            }
            WriteFile(toWrite);
            Close();
            Open();
            ReadConfig();
        }
        public void BuildCNF(Control.ControlCollection controls)
        {
            UInt16 posID = 1;
            CNF.Clear();
            foreach (FormLunchAppConfigurator control in controls)
            {
                CNF.Add(new CNF { ID = posID++,
                                  IsRunning = control.IsRunning,
                                  NbReboot = Convert.ToUInt16(control.numericUpDownNbReboot.Value),
                                  NbRebootDone = control.NbRebootDone,
                                  InstallationDone = (control.checkBoxInstallationState.CheckState == CheckState.Indeterminate ||
                                                     (control.checkBoxInstallationState.CheckState == CheckState.Unchecked) ? false : true),
                                  Path = control.textBoxProgramPath.Text,
                                  Programm = control.textBoxProgramToLunch.Text});
            }
            WriteConfig();
        }
    }
}

using LunchApp.Models;

namespace LunchApp.UserControls.UCLunchAppConfigurator
{
    public partial class FormLunchAppConfigurator : Control
    {
        public Boolean IsReady { get; private set; }
        public Boolean IsRunning { get; private set; }
        public UInt16 ID { get; private set; } = 0;
        public UInt16 NbRebootDone { get; private set; }
        public String DefaultPathInstallation { get; private set; }

        public Boolean InstallationDone { get; set; }

        public FormLunchAppConfigurator(String defaultPath, UInt16 nextID)
        {
            ID = nextID;
            DefaultPathInstallation = defaultPath;
            InitializeComponent();
        }
        public FormLunchAppConfigurator(String defaultPath, LunchApp.Models.CNF cnf)
        {
            DefaultPathInstallation = defaultPath;
            InitializeComponent();

            if (cnf.ID != 0)
            {
                ID = cnf.ID;
            }
            InstallationDone = cnf.InstallationDone;
            textBoxProgramPath.Text = cnf.Path;
            textBoxProgramToLunch.Text = cnf.Programm;
            numericUpDownNbReboot.Value = cnf.NbReboot;
            IsRunning = cnf.IsRunning;

            checkBoxInstallationState.Checked = cnf.InstallationDone;
            NbRebootDone = cnf.NbRebootDone;
        }

        public void buttonSelectProgram_Click(object sender, EventArgs e)
        {
            if (DefaultPathInstallation.Length > 0)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.CheckPathExists = true;
                openFileDialog.InitialDirectory = DefaultPathInstallation;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    List<string> result = BuildStringFilename(openFileDialog.FileName);

                    if (result.Count == 2)
                    {
                        textBoxProgramPath.Text = result[0];
                        textBoxProgramToLunch.Text = result[1];
                    }
                }
            }
        }
        private List<String> BuildStringFilename(String filename)
        {
            List<String> result = new List<String>();

            String tempInstallationProgram = filename.Remove(0, DefaultPathInstallation.Length + 1);
            String[] tempResult = tempInstallationProgram.Split('\\');
            String resPath = "";
            for (int i = 0; i < tempResult.Length - 1; i++)
            {
                resPath += tempResult[i] + '\\';
            }

            result.Add(resPath);
            result.Add(tempResult[tempResult.Length - 1]);

            return result;
        }

        public void StartRunning()
        {
            IsRunning = true;
        }
        public bool Rebooting()
        {
            if (NbRebootDone < numericUpDownNbReboot.Value)
            {
                NbRebootDone++;
                return true;
            }
            return false;
        }
        public void SetReady()
        {
            if (textBoxProgramPath.Text.Length == 0) return;
            if (textBoxProgramToLunch.Text.Length == 0) return;

            this.IsReady = true;
        }
        private void FormLunchAppConfigurator_Leave(object sender, EventArgs e)
        {
            SetReady();
        }
    }
}
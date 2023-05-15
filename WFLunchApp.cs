using LunchApp.IO;
using System.Collections.ObjectModel;
using System.Diagnostics;
using UCLunchAppConfigurator;

namespace LunchApp
{
    public partial class WFLunchApp : Form
    {
        private String AppName = "LunchApp";
        Process Command = new Process();
        private Logger _logger;
        private CNFFile _cnf;
        private FormLunchAppConfigurator lunchAppConfigurator = new FormLunchAppConfigurator("");
        public ObservableCollection<FormLunchAppConfigurator>? ListInstallation { get; private set; }

        public WFLunchApp()
        {
            _logger = new Logger(AppName);
            _cnf = new CNFFile("Traitement.cnf");

            InitializeComponent();
            PrepareCommand();

            AssignCNFConfig();
            if (flowLayoutPanelUCInstallationConfiguration.Controls.Count > 0 && OneIsReady())
            {
                buttonLunchInstallation.Enabled = true;
            }
            else
            {
                buttonLunchInstallation.Enabled = false;
            }
            _logger.AddLogging(AppName, "Lancemnt de l'application");
        }

        private void PrepareCommand()
        {
            Command.StartInfo = new ProcessStartInfo();
            Command.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Command.StartInfo.FileName = "CMD.exe";
            Command.StartInfo.Arguments = "/C";
            Command.StartInfo.CreateNoWindow = true;
        }
        private void AssignCNFConfig()
        {
            if (_cnf.Pathname.Length > 0)
            {
                textBoxDefaultInstallationPath.Text = _cnf.Pathname;
                buttonPlus.Enabled = true;
                flowLayoutPanelUCInstallationConfiguration.Enabled = true;
                foreach (Models.CNF cnf in _cnf.CNF)
                {
                    FormLunchAppConfigurator form = new FormLunchAppConfigurator(_cnf.Pathname, cnf);
                    form.SetReady();
                    flowLayoutPanelUCInstallationConfiguration.Controls.Add(form);
                }
            }
        }
        private void buttonRootInstallationPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog setFolder = new FolderBrowserDialog();
            if (setFolder.ShowDialog() == DialogResult.OK)
            {
                textBoxDefaultInstallationPath.Text = setFolder.SelectedPath;
                buttonPlus.Enabled = true;
                flowLayoutPanelUCInstallationConfiguration.Enabled = true;

                _cnf.SetPathName(textBoxDefaultInstallationPath.Text);
            }
        }
        private void ucLunchAppConfigurator_Leave(object sender, EventArgs e)
        {
            if (((FormLunchAppConfigurator)sender).IsReady)
            {
                _cnf.BuildCNF(flowLayoutPanelUCInstallationConfiguration.Controls);

                buttonLunchInstallation.Enabled = true;
            }
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            FormLunchAppConfigurator toAdd = new UCLunchAppConfigurator.FormLunchAppConfigurator(textBoxDefaultInstallationPath.Text);
            toAdd.Leave += ucLunchAppConfigurator_Leave;
            flowLayoutPanelUCInstallationConfiguration.Controls.Add(toAdd);
        }

        private void flowLayoutPanelUCInstallationConfiguration_ControlAdded(object sender, ControlEventArgs e)
        {
            if (flowLayoutPanelUCInstallationConfiguration.Controls.Count > 0 && OneIsReady())
            {
                buttonLunchInstallation.Enabled = true;
            }
            else
            {
                buttonLunchInstallation.Enabled = false;
            }
        }
        private Boolean OneIsReady()
        {
            foreach (FormLunchAppConfigurator uc in flowLayoutPanelUCInstallationConfiguration.Controls)
            {
                if (uc.IsReady) return true;
            }
            return false;
        }

        private void WFLunchApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            _cnf.BuildCNF(flowLayoutPanelUCInstallationConfiguration.Controls);
        }

        private void flowLayoutPanelUCInstallationConfiguration_CursorChanged(object sender, EventArgs e)
        {
            if (flowLayoutPanelUCInstallationConfiguration.Controls.Count > 0 && OneIsReady())
            {
                buttonLunchInstallation.Enabled = true;
            }
            else
            {
                buttonLunchInstallation.Enabled = false;
            }
        }

        private void buttonLunchInstallation_Click(object sender, EventArgs e)
        {
            UserConfirmation userConfirmation = new UserConfirmation();
            var result = userConfirmation.ShowDialog();

            if (result == DialogResult.OK)
            {
                progressBarTraitement.Maximum = flowLayoutPanelUCInstallationConfiguration.Controls.Count;
                progressBarTraitement.Step = 1;
                foreach (FormLunchAppConfigurator uc in flowLayoutPanelUCInstallationConfiguration.Controls)
                {
                    if (uc.checkBoxInstallationState.CheckState != CheckState.Checked)
                    {
                    }
                    progressBarTraitement.PerformStep();
                }
            }
        }
    }
}
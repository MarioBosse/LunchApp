using LunchApp.IO;
using System.Collections.ObjectModel;
using UCLunchAppConfigurator;

namespace LunchApp
{
    public partial class WFLunchApp : Form
    {
        private String AppName = "LunchApp";
        private Logger _logger;
        private CNFFile _cnf;
        private FormLunchAppConfigurator lunchAppConfigurator = new FormLunchAppConfigurator("");
        public ObservableCollection<FormLunchAppConfigurator>? ListInstallation { get; private set; }

        public WFLunchApp()
        {
            _logger = new Logger(AppName);
            _cnf = new CNFFile("Traitement.cnf");

            InitializeComponent();

            AssignCNFConfig();
            _logger.AddLogging(AppName, "Lancemnt de l'application");
        }

        private void AssignCNFConfig()
        {
            if (_cnf.Pathname.Length > 0)
            {
                textBoxDefaultInstallationPath.Text = _cnf.Pathname;
                buttonPlus.Enabled = true;
                flowLayoutPanelUCInstallationConfiguration.Enabled = true;
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
    }
}
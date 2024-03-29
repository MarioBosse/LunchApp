using LunchApp.IO;
using LunchApp.UserControls.UCLunchAppConfigurator;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace LunchApp.Forms
{
    public partial class WFLunchApp : Form
    {
        private String AppName = "LunchApp";
        private UInt16 nextID { get; set; } = 0;
        private Logger _logger;
        private CNFFile _cnf;
        private ProcessStartInfo? psi;

        public ObservableCollection<FormLunchAppConfigurator>? ListInstallation { get; private set; }

        public WFLunchApp()
        {
            _logger = new Logger(AppName);
            _cnf = new CNFFile("Traitement.cnf");

            InitializeComponent();

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

        private void PrepareCommand(String path)
        {
            psi = new ProcessStartInfo(path);
            psi.WindowStyle = ProcessWindowStyle.Normal;
            psi.Arguments = "/C " + '"' + path;
            psi.CreateNoWindow = false;
            psi.UseShellExecute = true;
            psi.ErrorDialog = true;

            psi.WorkingDirectory = path;
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
                    nextID = nextID > cnf.ID ? nextID : cnf.ID;
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
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            FormLunchAppConfigurator toAdd = new FormLunchAppConfigurator(textBoxDefaultInstallationPath.Text, nextID++);
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
            flowLayoutPanelUCInstallationConfiguration.Enabled = false;
            _cnf.BuildCNF(flowLayoutPanelUCInstallationConfiguration.Controls);

            //UserConfirmation userConfirmation = new UserConfirmation();
            //if (userConfirmation.ShowDialog() == DialogResult.OK)
            {
                //SecureString SecurePassword = new SecureString();
                //foreach (char c in userConfirmation.textBoxPassword.Text)
                //{
                //    SecurePassword.AppendChar(c);
                //}
                progressBarTraitement.Maximum = _cnf.NbProgress;
                progressBarTraitement.Value = 0;
                progressBarTraitement.Step = 1;
                foreach (FormLunchAppConfigurator uc in flowLayoutPanelUCInstallationConfiguration.Controls)
                {
                    PrepareCommand(_cnf.Pathname + '\\' + uc.textBoxProgramPath.Text + '\\');

                    //psi.UserName = userConfirmation.textBoxUtilisateur.Text;
                    //psi.Password = SecurePassword;
                    //psi.Domain = userConfirmation.textBoxDomaine.Text;

                    // V�rifier si l'application a d�j� �t� lanc�, est-ce compl�t�, ...
                    if (uc.IsRunning && uc.NbRebootDone == uc.numericUpDownNbReboot.Value)
                    {
                        uc.checkBoxInstallationState.Checked = true;
                        uc.InstallationDone = (uc.checkBoxInstallationState.CheckState == CheckState.Indeterminate ||
                                              (uc.checkBoxInstallationState.CheckState == CheckState.Unchecked) ? false : true);

                        _cnf.BuildCNF(flowLayoutPanelUCInstallationConfiguration.Controls);
                    }
                    progressBarTraitement.PerformStep();
                    progressBarTraitement.Show();

                    // Si l'installation est compl�t�, passer a la suivante.
                    if (uc.checkBoxInstallationState.CheckState != CheckState.Checked)
                    {
                        // D�marrage de l'installation
                        if (psi == null) psi = new ProcessStartInfo();

                        psi.FileName = uc.textBoxProgramToLunch.Text;

                        // Modifier l'�tat du traitement de l'installation
                        uc.checkBoxInstallationState.CheckState = CheckState.Unchecked;
                        uc.StartRunning();

                        // Sauvegarder le fichier de configuration
                        _cnf.BuildCNF(flowLayoutPanelUCInstallationConfiguration.Controls);

                        // Si il y a plusieur d�marrage, ajouter un � NBReboot
                        // Lancer l'installation
                        //Command.StartInfo = psi;
                        String argument = psi.Arguments + psi.FileName + '"';

                        var Com = System.Diagnostics.Process.Start("cmd", argument);
                        Com.WaitForExit();

                        // Nombre de red�marrage requis avant que l'installation soit compl�t�e
                        // Red�marre si requis
                        if (uc.Rebooting())
                        {
                            _cnf.BuildCNF(flowLayoutPanelUCInstallationConfiguration.Controls);
                            Reboot.RestartForce();
                        }
                        else if(uc.numericUpDownNbReboot.Value == 0)
                        {
                            uc.InstallationDone = true;
                            _cnf.BuildCNF(flowLayoutPanelUCInstallationConfiguration.Controls);
                        }
                    }
                }
            }
            flowLayoutPanelUCInstallationConfiguration.Enabled = true;
        }
    }
}
namespace LunchApp.Forms
{
    public partial class UserConfirmation : Form
    {
        public UserConfirmation()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void textBoxConnexion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((textBoxUtilisateur.Text.Length > 0) &&
               (textBoxPassword.Text.Length > 0) &&
               (textBoxDomaine.Text.Length > 0))
            {
                buttonConfirm.Enabled = true;
            }
            else
                buttonConfirm.Enabled = false;
        }
    }
}

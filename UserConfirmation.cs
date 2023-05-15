using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchApp
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
            if((textBoxUtilisateur.Text.Length > 0) &&
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

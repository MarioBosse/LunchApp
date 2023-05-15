namespace LunchApp
{
    partial class UserConfirmation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelUtilisateur = new Label();
            textBoxUtilisateur = new TextBox();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            textBoxDomaine = new TextBox();
            labelDomaine = new Label();
            buttonCancel = new Button();
            buttonConfirm = new Button();
            SuspendLayout();
            // 
            // labelUtilisateur
            // 
            labelUtilisateur.AutoSize = true;
            labelUtilisateur.Location = new Point(18, 18);
            labelUtilisateur.Name = "labelUtilisateur";
            labelUtilisateur.Size = new Size(60, 15);
            labelUtilisateur.TabIndex = 0;
            labelUtilisateur.Text = "Utilisateur";
            // 
            // textBoxUtilisateur
            // 
            textBoxUtilisateur.Location = new Point(18, 36);
            textBoxUtilisateur.Name = "textBoxUtilisateur";
            textBoxUtilisateur.Size = new Size(119, 23);
            textBoxUtilisateur.TabIndex = 1;
            textBoxUtilisateur.KeyPress += textBoxConnexion_KeyPress;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(18, 86);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(119, 23);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.KeyPress += textBoxConnexion_KeyPress;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(18, 68);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(77, 15);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Mot de passe";
            // 
            // textBoxDomaine
            // 
            textBoxDomaine.Location = new Point(182, 36);
            textBoxDomaine.Name = "textBoxDomaine";
            textBoxDomaine.Size = new Size(119, 23);
            textBoxDomaine.TabIndex = 5;
            textBoxDomaine.Tag = "";
            textBoxDomaine.Text = "cscapitale.qc.ca";
            textBoxDomaine.KeyPress += textBoxConnexion_KeyPress;
            // 
            // labelDomaine
            // 
            labelDomaine.AutoSize = true;
            labelDomaine.Location = new Point(182, 18);
            labelDomaine.Name = "labelDomaine";
            labelDomaine.Size = new Size(55, 15);
            labelDomaine.TabIndex = 4;
            labelDomaine.Text = "Domaine";
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(255, 128, 128);
            buttonCancel.Location = new Point(18, 115);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Enabled = false;
            buttonConfirm.Location = new Point(226, 115);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(75, 23);
            buttonConfirm.TabIndex = 7;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // UserConfirmation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 147);
            Controls.Add(buttonConfirm);
            Controls.Add(buttonCancel);
            Controls.Add(textBoxDomaine);
            Controls.Add(labelDomaine);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(textBoxUtilisateur);
            Controls.Add(labelUtilisateur);
            Name = "UserConfirmation";
            Text = "Connexion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUtilisateur;
        private TextBox textBoxUtilisateur;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private TextBox textBoxDomaine;
        private Label labelDomaine;
        private Button buttonCancel;
        private Button buttonConfirm;
    }
}
namespace LunchApp.UserControls.UCLunchAppConfigurator
{
    partial class FormLunchAppConfigurator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelPathInstallation = new Label();
            labelProgramToLunch = new Label();
            labelNbReboot = new Label();
            textBoxProgramPath = new TextBox();
            textBoxProgramToLunch = new TextBox();
            buttonSelectProgram = new Button();
            numericUpDownNbReboot = new NumericUpDown();
            checkBoxInstallationState = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNbReboot).BeginInit();
            SuspendLayout();
            // 
            // labelPathInstallation
            // 
            labelPathInstallation.AccessibleRole = AccessibleRole.ScrollBar;
            labelPathInstallation.AutoSize = true;
            labelPathInstallation.Location = new Point(1, 4);
            labelPathInstallation.Name = "labelPathInstallation";
            labelPathInstallation.Size = new Size(132, 15);
            labelPathInstallation.TabIndex = 0;
            labelPathInstallation.Text = "Répertoire d'installation";
            // 
            // labelProgramToLunch
            // 
            labelProgramToLunch.AutoSize = true;
            labelProgramToLunch.Location = new Point(295, 4);
            labelProgramToLunch.Name = "labelProgramToLunch";
            labelProgramToLunch.Size = new Size(114, 15);
            labelProgramToLunch.TabIndex = 1;
            labelProgramToLunch.Text = "Programme a lancer";
            // 
            // labelNbReboot
            // 
            labelNbReboot.AutoSize = true;
            labelNbReboot.Location = new Point(475, 4);
            labelNbReboot.Name = "labelNbReboot";
            labelNbReboot.Size = new Size(96, 15);
            labelNbReboot.TabIndex = 2;
            labelNbReboot.Text = "Nb Redémarrage";
            // 
            // textBoxProgramPath
            // 
            textBoxProgramPath.Enabled = false;
            textBoxProgramPath.Location = new Point(1, 22);
            textBoxProgramPath.Name = "textBoxProgramPath";
            textBoxProgramPath.Size = new Size(288, 23);
            textBoxProgramPath.TabIndex = 1;
            // 
            // textBoxProgramToLunch
            // 
            textBoxProgramToLunch.Enabled = false;
            textBoxProgramToLunch.Location = new Point(295, 21);
            textBoxProgramToLunch.Name = "textBoxProgramToLunch";
            textBoxProgramToLunch.Size = new Size(114, 23);
            textBoxProgramToLunch.TabIndex = 2;
            // 
            // buttonSelectProgram
            // 
            buttonSelectProgram.Location = new Point(415, 22);
            buttonSelectProgram.Name = "buttonSelectProgram";
            buttonSelectProgram.Size = new Size(54, 23);
            buttonSelectProgram.TabIndex = 3;
            buttonSelectProgram.Text = "Choisir";
            buttonSelectProgram.UseVisualStyleBackColor = true;
            buttonSelectProgram.Click += buttonSelectProgram_Click;
            // 
            // numericUpDownNbReboot
            // 
            numericUpDownNbReboot.Location = new Point(475, 22);
            numericUpDownNbReboot.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDownNbReboot.Name = "numericUpDownNbReboot";
            numericUpDownNbReboot.Size = new Size(96, 23);
            numericUpDownNbReboot.TabIndex = 4;
            // 
            // checkBoxInstallationState
            // 
            checkBoxInstallationState.Checked = true;
            checkBoxInstallationState.CheckState = CheckState.Indeterminate;
            checkBoxInstallationState.Location = new Point(428, -3);
            checkBoxInstallationState.Name = "checkBoxInstallationState";
            checkBoxInstallationState.Size = new Size(22, 24);
            checkBoxInstallationState.TabIndex = 0;
            checkBoxInstallationState.Visible = false;
            // 
            // FormLunchAppConfigurator
            // 
            BackColor = SystemColors.Control;
            ClientSize = new Size(576, 49);
            Controls.Add(checkBoxInstallationState);
            Controls.Add(numericUpDownNbReboot);
            Controls.Add(buttonSelectProgram);
            Controls.Add(textBoxProgramToLunch);
            Controls.Add(textBoxProgramPath);
            Controls.Add(labelNbReboot);
            Controls.Add(labelProgramToLunch);
            Controls.Add(labelPathInstallation);
            Name = "FormLunchAppConfigurator";
            Text = "Lunch Application Configurator";
            Leave += FormLunchAppConfigurator_Leave;
            ((System.ComponentModel.ISupportInitialize)numericUpDownNbReboot).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label labelPathInstallation;
        public Label labelProgramToLunch;
        public Label labelNbReboot;
        public TextBox textBoxProgramPath;
        public TextBox textBoxProgramToLunch;
        public Button buttonSelectProgram;
        public NumericUpDown numericUpDownNbReboot;
        public CheckBox checkBoxInstallationState;
    }
}
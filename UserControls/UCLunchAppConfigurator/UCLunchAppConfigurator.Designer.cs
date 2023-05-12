﻿namespace UCLunchAppConfigurator
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
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // labelPathInstallation
            // 
            labelPathInstallation.AccessibleRole = AccessibleRole.ScrollBar;
            labelPathInstallation.AutoSize = true;
            labelPathInstallation.Location = new Point(6, 5);
            labelPathInstallation.Name = "labelPathInstallation";
            labelPathInstallation.Size = new Size(132, 15);
            labelPathInstallation.TabIndex = 0;
            labelPathInstallation.Text = "Répertoire d'installation";
            // 
            // labelProgramToLunch
            // 
            labelProgramToLunch.AutoSize = true;
            labelProgramToLunch.Location = new Point(300, 5);
            labelProgramToLunch.Name = "labelProgramToLunch";
            labelProgramToLunch.Size = new Size(114, 15);
            labelProgramToLunch.TabIndex = 1;
            labelProgramToLunch.Text = "Programme a lancer";
            // 
            // labelNbReboot
            // 
            labelNbReboot.AutoSize = true;
            labelNbReboot.Location = new Point(481, 5);
            labelNbReboot.Name = "labelNbReboot";
            labelNbReboot.Size = new Size(96, 15);
            labelNbReboot.TabIndex = 2;
            labelNbReboot.Text = "Nb Redémarrage";
            // 
            // textBoxProgramPath
            // 
            textBoxProgramPath.Enabled = false;
            textBoxProgramPath.Location = new Point(6, 23);
            textBoxProgramPath.Name = "textBoxProgramPath";
            textBoxProgramPath.Size = new Size(288, 23);
            textBoxProgramPath.TabIndex = 1;
            // 
            // textBoxProgramToLunch
            // 
            textBoxProgramToLunch.Enabled = false;
            textBoxProgramToLunch.Location = new Point(300, 23);
            textBoxProgramToLunch.Name = "textBoxProgramToLunch";
            textBoxProgramToLunch.Size = new Size(114, 23);
            textBoxProgramToLunch.TabIndex = 2;
            // 
            // buttonSelectProgram
            // 
            buttonSelectProgram.Location = new Point(420, 23);
            buttonSelectProgram.Name = "buttonSelectProgram";
            buttonSelectProgram.Size = new Size(54, 23);
            buttonSelectProgram.TabIndex = 3;
            buttonSelectProgram.Text = "Choisir";
            buttonSelectProgram.UseVisualStyleBackColor = true;
            buttonSelectProgram.Click += buttonSelectProgram_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(481, 23);
            numericUpDown1.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(96, 23);
            numericUpDown1.TabIndex = 4;
            // 
            // FormLunchAppConfigurator
            // 
            ClientSize = new Size(583, 54);
            Controls.Add(numericUpDown1);
            Controls.Add(buttonSelectProgram);
            Controls.Add(textBoxProgramToLunch);
            Controls.Add(textBoxProgramPath);
            Controls.Add(labelNbReboot);
            Controls.Add(labelProgramToLunch);
            Controls.Add(labelPathInstallation);
            Name = "FormLunchAppConfigurator";
            Text = "Lunch Application Configurator";
            Leave += FormLunchAppConfigurator_Leave;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
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
        public NumericUpDown numericUpDown1;
    }
}
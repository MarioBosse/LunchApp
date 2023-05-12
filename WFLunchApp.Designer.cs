namespace LunchApp
{
    partial class WFLunchApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WFLunchApp));
            labelOriginInstallationPath = new Label();
            textBoxDefaultInstallationPath = new TextBox();
            buttonRootInstallationPath = new Button();
            buttonUp = new Button();
            buttonPlus = new Button();
            buttonDown = new Button();
            buttonMinus = new Button();
            buttonLunchInstallation = new Button();
            flowLayoutPanelUCInstallationConfiguration = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // labelOriginInstallationPath
            // 
            labelOriginInstallationPath.AutoSize = true;
            labelOriginInstallationPath.Location = new Point(12, 9);
            labelOriginInstallationPath.Name = "labelOriginInstallationPath";
            labelOriginInstallationPath.Size = new Size(179, 15);
            labelOriginInstallationPath.TabIndex = 0;
            labelOriginInstallationPath.Text = "Répertoire d'installation récurent";
            // 
            // textBoxDefaultInstallationPath
            // 
            textBoxDefaultInstallationPath.Location = new Point(12, 27);
            textBoxDefaultInstallationPath.Name = "textBoxDefaultInstallationPath";
            textBoxDefaultInstallationPath.Size = new Size(451, 23);
            textBoxDefaultInstallationPath.TabIndex = 1;
            // 
            // buttonRootInstallationPath
            // 
            buttonRootInstallationPath.Location = new Point(713, 27);
            buttonRootInstallationPath.Name = "buttonRootInstallationPath";
            buttonRootInstallationPath.Size = new Size(75, 23);
            buttonRootInstallationPath.TabIndex = 2;
            buttonRootInstallationPath.Text = "Choisir";
            buttonRootInstallationPath.UseVisualStyleBackColor = true;
            buttonRootInstallationPath.Click += buttonRootInstallationPath_Click;
            // 
            // buttonUp
            // 
            buttonUp.BackgroundImage = (Image)resources.GetObject("buttonUp.BackgroundImage");
            buttonUp.BackgroundImageLayout = ImageLayout.Zoom;
            buttonUp.Enabled = false;
            buttonUp.Location = new Point(752, 164);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(36, 30);
            buttonUp.TabIndex = 4;
            buttonUp.UseVisualStyleBackColor = true;
            // 
            // buttonPlus
            // 
            buttonPlus.BackgroundImage = (Image)resources.GetObject("buttonPlus.BackgroundImage");
            buttonPlus.BackgroundImageLayout = ImageLayout.Zoom;
            buttonPlus.Enabled = false;
            buttonPlus.Location = new Point(752, 197);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(36, 30);
            buttonPlus.TabIndex = 5;
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonDown
            // 
            buttonDown.BackgroundImage = (Image)resources.GetObject("buttonDown.BackgroundImage");
            buttonDown.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDown.Enabled = false;
            buttonDown.Location = new Point(752, 263);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(36, 30);
            buttonDown.TabIndex = 7;
            buttonDown.UseVisualStyleBackColor = true;
            // 
            // buttonMinus
            // 
            buttonMinus.BackgroundImage = (Image)resources.GetObject("buttonMinus.BackgroundImage");
            buttonMinus.BackgroundImageLayout = ImageLayout.Zoom;
            buttonMinus.Enabled = false;
            buttonMinus.Location = new Point(752, 230);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(36, 30);
            buttonMinus.TabIndex = 6;
            buttonMinus.UseVisualStyleBackColor = true;
            // 
            // buttonLunchInstallation
            // 
            buttonLunchInstallation.Enabled = false;
            buttonLunchInstallation.Location = new Point(12, 419);
            buttonLunchInstallation.Margin = new Padding(3, 2, 3, 2);
            buttonLunchInstallation.Name = "buttonLunchInstallation";
            buttonLunchInstallation.Size = new Size(734, 22);
            buttonLunchInstallation.TabIndex = 8;
            buttonLunchInstallation.Text = "Lancez les installations";
            buttonLunchInstallation.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelUCInstallationConfiguration
            // 
            flowLayoutPanelUCInstallationConfiguration.AutoScroll = true;
            flowLayoutPanelUCInstallationConfiguration.Enabled = false;
            flowLayoutPanelUCInstallationConfiguration.Location = new Point(12, 52);
            flowLayoutPanelUCInstallationConfiguration.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanelUCInstallationConfiguration.Name = "flowLayoutPanelUCInstallationConfiguration";
            flowLayoutPanelUCInstallationConfiguration.Size = new Size(639, 362);
            flowLayoutPanelUCInstallationConfiguration.TabIndex = 9;
            flowLayoutPanelUCInstallationConfiguration.ControlAdded += flowLayoutPanelUCInstallationConfiguration_ControlAdded;
            flowLayoutPanelUCInstallationConfiguration.ControlRemoved += flowLayoutPanelUCInstallationConfiguration_ControlAdded;
            // 
            // WFLunchApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanelUCInstallationConfiguration);
            Controls.Add(buttonLunchInstallation);
            Controls.Add(buttonDown);
            Controls.Add(buttonMinus);
            Controls.Add(buttonPlus);
            Controls.Add(buttonUp);
            Controls.Add(buttonRootInstallationPath);
            Controls.Add(textBoxDefaultInstallationPath);
            Controls.Add(labelOriginInstallationPath);
            Name = "WFLunchApp";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelOriginInstallationPath;
        private TextBox textBoxDefaultInstallationPath;
        private Button buttonRootInstallationPath;
        private Button buttonUp;
        private Button buttonPlus;
        private Button buttonDown;
        private Button buttonMinus;
        private Button buttonLunchInstallation;
        private FlowLayoutPanel flowLayoutPanelUCInstallationConfiguration;
    }
}
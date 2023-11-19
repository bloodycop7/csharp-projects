namespace WinFormsApp2
{
    partial class page_settingsButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            settingsLabel = new Label();
            toggleDMLabel = new Label();
            checkBox_darkMode = new CheckBox();
            SuspendLayout();
            // 
            // settingsLabel
            // 
            settingsLabel.AutoSize = true;
            settingsLabel.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            settingsLabel.Location = new Point(328, 11);
            settingsLabel.Name = "settingsLabel";
            settingsLabel.Size = new Size(135, 39);
            settingsLabel.TabIndex = 0;
            settingsLabel.Text = "Settings";
            // 
            // toggleDMLabel
            // 
            toggleDMLabel.AutoSize = true;
            toggleDMLabel.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
            toggleDMLabel.Location = new Point(0, 81);
            toggleDMLabel.Name = "toggleDMLabel";
            toggleDMLabel.Size = new Size(214, 25);
            toggleDMLabel.TabIndex = 1;
            toggleDMLabel.Text = "Toggle Dark Mode";
            // 
            // checkBox_darkMode
            // 
            checkBox_darkMode.AutoSize = true;
            checkBox_darkMode.Location = new Point(220, 90);
            checkBox_darkMode.Name = "checkBox_darkMode";
            checkBox_darkMode.Size = new Size(15, 14);
            checkBox_darkMode.TabIndex = 2;
            checkBox_darkMode.TextImageRelation = TextImageRelation.ImageBeforeText;
            checkBox_darkMode.UseVisualStyleBackColor = true;
            checkBox_darkMode.CheckedChanged += checkBox_darkMode_CheckedChanged;
            // 
            // settingspage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(checkBox_darkMode);
            Controls.Add(toggleDMLabel);
            Controls.Add(settingsLabel);
            Name = "settingspage";
            Size = new Size(791, 410);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label settingsLabel;
        public Label toggleDMLabel;
        public CheckBox checkBox_darkMode;
    }
}

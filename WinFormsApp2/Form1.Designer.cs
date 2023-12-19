namespace WinFormsApp2
{
    partial class Form1
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
            panel1 = new Panel();
            page_creditsButton = new Button();
            page_settingsButton = new Button();
            page_homeButton = new Button();
            topContainer = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(page_creditsButton);
            panel1.Controls.Add(page_settingsButton);
            panel1.Controls.Add(page_homeButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(791, 40);
            panel1.TabIndex = 0;
            // 
            // page_creditsButton
            // 
            page_creditsButton.Dock = DockStyle.Left;
            page_creditsButton.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            page_creditsButton.Location = new Point(520, 0);
            page_creditsButton.Margin = new Padding(0);
            page_creditsButton.Name = "page_creditsButton";
            page_creditsButton.Size = new Size(271, 40);
            page_creditsButton.TabIndex = 3;
            page_creditsButton.Text = "Credits";
            page_creditsButton.UseVisualStyleBackColor = true;
            page_creditsButton.Click += button3_Click;
            // 
            // page_settingsButton
            // 
            page_settingsButton.Dock = DockStyle.Left;
            page_settingsButton.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            page_settingsButton.Location = new Point(260, 0);
            page_settingsButton.Margin = new Padding(0);
            page_settingsButton.Name = "page_settingsButton";
            page_settingsButton.Size = new Size(260, 40);
            page_settingsButton.TabIndex = 2;
            page_settingsButton.Text = "Settings";
            page_settingsButton.UseVisualStyleBackColor = true;
            page_settingsButton.Click += button2_Click;
            // 
            // page_homeButton
            // 
            page_homeButton.Dock = DockStyle.Left;
            page_homeButton.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            page_homeButton.Location = new Point(0, 0);
            page_homeButton.Margin = new Padding(0);
            page_homeButton.Name = "page_homeButton";
            page_homeButton.Size = new Size(260, 40);
            page_homeButton.TabIndex = 1;
            page_homeButton.Text = "Home";
            page_homeButton.UseVisualStyleBackColor = true;
            page_homeButton.Click += button1_Click;
            // 
            // topContainer
            // 
            topContainer.BackColor = Color.Transparent;
            topContainer.Dock = DockStyle.Fill;
            topContainer.ForeColor = SystemColors.ControlText;
            topContainer.Location = new Point(0, 40);
            topContainer.Name = "topContainer";
            topContainer.Size = new Size(791, 410);
            topContainer.TabIndex = 1;
            topContainer.Paint += panelContainer_Paint;
            // 
            // Form1
            // 
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 450);
            Controls.Add(topContainer);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel topContainer;
        private Button page_creditsButton;
        private Button page_settingsButton;
        private Button page_homeButton;
    }
}
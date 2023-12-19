namespace WinFormsApp2
{
    partial class page_creditsButton
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
            creditsLabel = new Label();
            credit_eon = new LinkLabel();
            credit_andji = new LinkLabel();
            SuspendLayout();
            // 
            // creditsLabel
            // 
            creditsLabel.AutoSize = true;
            creditsLabel.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            creditsLabel.Location = new Point(333, 9);
            creditsLabel.Name = "creditsLabel";
            creditsLabel.Size = new Size(125, 39);
            creditsLabel.TabIndex = 0;
            creditsLabel.Text = "Credits";
            // 
            // credit_eon
            // 
            credit_eon.ActiveLinkColor = Color.FromArgb(255, 192, 128);
            credit_eon.AutoSize = true;
            credit_eon.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            credit_eon.LinkColor = Color.Gray;
            credit_eon.Location = new Point(3, 61);
            credit_eon.Name = "credit_eon";
            credit_eon.RightToLeft = RightToLeft.No;
            credit_eon.Size = new Size(351, 23);
            credit_eon.TabIndex = 1;
            credit_eon.TabStop = true;
            credit_eon.Text = "eon ( Добрин ) - Main Programmer";
            credit_eon.LinkClicked += credit_eon_LinkClicked;
            // 
            // credit_andji
            // 
            credit_andji.ActiveLinkColor = Color.FromArgb(255, 192, 128);
            credit_andji.AutoSize = true;
            credit_andji.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            credit_andji.LinkColor = Color.Gray;
            credit_andji.Location = new Point(3, 97);
            credit_andji.Name = "credit_andji";
            credit_andji.RightToLeft = RightToLeft.No;
            credit_andji.Size = new Size(222, 23);
            credit_andji.TabIndex = 2;
            credit_andji.TabStop = true;
            credit_andji.Text = "Анджела- UI Designer";
            // 
            // creditspage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(credit_andji);
            Controls.Add(credit_eon);
            Controls.Add(creditsLabel);
            Name = "creditspage";
            Size = new Size(791, 410);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label creditsLabel;
        private LinkLabel credit_eon;
        private LinkLabel credit_andji;
    }
}

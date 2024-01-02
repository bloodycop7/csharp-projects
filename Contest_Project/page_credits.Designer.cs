namespace Contest_Project
{
    partial class page_credits
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
            if (disposing && ( components != null ))
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
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            ( (System.ComponentModel.ISupportInitialize) pictureBox1 ).BeginInit();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Cairo", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point,  0);
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.Location = new Point(3, 114);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(392, 45);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Dobrin (eon) - Main Programmer (8 г)";
            linkLabel1.UseMnemonic = false;
            linkLabel1.LinkClicked +=  linkLabel1_LinkClicked ;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom;
            pictureBox1.Image = Properties.Resources.pgee_header;
            pictureBox1.Location = new Point(143, 373);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(445, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // page_credits
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Name = "page_credits";
            Size = new Size(731, 450);
            ( (System.ComponentModel.ISupportInitialize) pictureBox1 ).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
    }
}

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
            topContainer = new Panel();
             SuspendLayout();
            // 
            // topContainer
            // 
            topContainer .BackColor = Color .Transparent;
            topContainer .Dock = DockStyle .Fill;
            topContainer .ForeColor = SystemColors .ControlText;
            topContainer .Location = new Point(0, 0);
            topContainer .Name = "topContainer";
            topContainer .Size = new Size(791, 450);
            topContainer .TabIndex = 1;
            topContainer .Paint +=   panelContainer_Paint ;
            // 
            // Form1
            // 
             AccessibleName = "";
             AutoScaleDimensions = new SizeF(7F, 15F);
             AutoScaleMode = AutoScaleMode .Font;
             ClientSize = new Size(791, 450);
             Controls .Add(topContainer);
             FormBorderStyle = FormBorderStyle .FixedSingle;
             Name = "Form1";
             StartPosition = FormStartPosition .CenterScreen;
             Tag = "";
             Text = "Form1";
             Load +=   Form1_Load ;
             ResumeLayout(false);
        }

        #endregion
        private Button button3;
        private Button button1;
        private Panel topContainer;
    }
}
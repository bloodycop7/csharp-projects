namespace WinFormsApp1
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelContainer = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panelContainer);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(751, 40);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Left;
            button3.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(500, 0);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(250, 40);
            button3.TabIndex = 3;
            button3.Text = "Credits";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Left;
            button2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(250, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(250, 40);
            button2.TabIndex = 2;
            button2.Text = "Settings";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Left;
            button1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(250, 40);
            button1.TabIndex = 1;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panelContainer.Location = new Point(3, 43);
            panelContainer.Name = "panel2";
            panelContainer.Size = new Size(747, 395);
            panelContainer.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 36);
            panel3.Name = "panel3";
            panel3.Size = new Size(751, 413);
            panel3.TabIndex = 1;
            panel3.Tag = "panelContainer";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 450);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "panelContainer";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Panel panelContainer;
        private Panel panel3;
    }
}
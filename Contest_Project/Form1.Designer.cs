namespace Contest_Project
{
    partial class parent_panel
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
            if (disposing && ( components != null ))
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
            container_left = new Panel();
            container_left_button_credits = new Button();
            container_left_button_home = new Button();
            label1 = new Label();
            container_main = new Panel();
            container_left.SuspendLayout();
            SuspendLayout();
            // 
            // container_left
            // 
            container_left.BackColor = SystemColors.ButtonHighlight;
            container_left.Controls.Add(container_left_button_credits);
            container_left.Controls.Add(container_left_button_home);
            container_left.Dock = DockStyle.Left;
            container_left.Location = new Point(0, 0);
            container_left.Name = "container_left";
            container_left.Size = new Size(85, 450);
            container_left.TabIndex = 0;
            container_left.Paint +=  container_left_Paint ;
            // 
            // container_left_button_credits
            // 
            container_left_button_credits.AutoSize = true;
            container_left_button_credits.BackColor = SystemColors.ControlDark;
            container_left_button_credits.Dock = DockStyle.Top;
            container_left_button_credits.Font = new Font("Cairo", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point,  0);
            container_left_button_credits.Location = new Point(0, 50);
            container_left_button_credits.Margin = new Padding(0);
            container_left_button_credits.Name = "container_left_button_credits";
            container_left_button_credits.Padding = new Padding(1);
            container_left_button_credits.Size = new Size(85, 52);
            container_left_button_credits.TabIndex = 2;
            container_left_button_credits.Text = "Credits";
            container_left_button_credits.UseVisualStyleBackColor = false;
            // 
            // container_left_button_home
            // 
            container_left_button_home.AutoSize = true;
            container_left_button_home.BackColor = SystemColors.ControlDark;
            container_left_button_home.Dock = DockStyle.Top;
            container_left_button_home.Font = new Font("Cairo", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point,  0);
            container_left_button_home.Location = new Point(0, 0);
            container_left_button_home.Margin = new Padding(0);
            container_left_button_home.Name = "container_left_button_home";
            container_left_button_home.Size = new Size(85, 50);
            container_left_button_home.TabIndex = 1;
            container_left_button_home.Text = "Home";
            container_left_button_home.UseVisualStyleBackColor = false;
            container_left_button_home.Click +=  container_left_button_home_Click ;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(336, 35);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "Text Label";
            // 
            // container_main
            // 
            container_main.Dock = DockStyle.Fill;
            container_main.Location = new Point(85, 0);
            container_main.Name = "container_main";
            container_main.Size = new Size(715, 450);
            container_main.TabIndex = 2;
            // 
            // parent_panel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(container_main);
            Controls.Add(container_left);
            Controls.Add(label1);
            Name = "parent_panel";
            Text = "Form1";
            container_left.ResumeLayout(false);
            container_left.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel container_left;
        private Button container_left_button_home;
        private Button container_left_button_credits;
        private Label label1;
        private Panel container_main;
    }
}

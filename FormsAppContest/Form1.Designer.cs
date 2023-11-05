using System.Timers;

namespace FormsAppContest
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
            label1 = new Label();
            checkBox1 = new CheckBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 23F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(234, 42);
            label1.TabIndex = 0;
            label1.Text = "English Practice";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(420, 45);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(150, 25);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Toggle Dark Mode";
            checkBox1.TextAlign = ContentAlignment.TopRight;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 23F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(451, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 42);
            label2.TabIndex = 2;
            label2.Text = "Settings";
            label2.TextAlign = ContentAlignment.TopRight;
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Hello", "Goodbye", "Apple" });
            comboBox1.Location = new Point(25, 85);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            comboBox1.Text = "Здравей";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.SelectedValueChanged += comboBox1_SelectedValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(573, 500);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBox1.Text = "Correct";
        }

        #endregion

        private Label label1;
        private CheckBox checkBox1;
        private Label label2;
        private ComboBox comboBox1;
    }
}
namespace WinFormsApp1
{
    partial class AdminEditPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label4 = new Label();
            button3 = new Button();
            textBox4 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(306, 7);
            label1.Name = "label1";
            label1.Size = new Size(189, 41);
            label1.TabIndex = 4;
            label1.Text = "Airport App";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(-2, -4);
            label6.Name = "label6";
            label6.Size = new Size(142, 23);
            label6.TabIndex = 16;
            label6.Text = "Admin Acc page";
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(270, 338);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 17;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(10, 410);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 18;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(352, 220);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(189, 27);
            textBox3.TabIndex = 30;
            textBox3.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(218, 222);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 29;
            label3.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(352, 169);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(189, 27);
            textBox2.TabIndex = 28;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(352, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 27);
            textBox1.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(229, 169);
            label2.Name = "label2";
            label2.Size = new Size(54, 23);
            label2.TabIndex = 26;
            label2.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(218, 121);
            label4.Name = "label4";
            label4.Size = new Size(94, 23);
            label4.TabIndex = 25;
            label4.Text = "User name";
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(445, 338);
            button3.Name = "button3";
            button3.Size = new Size(95, 29);
            button3.TabIndex = 31;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(352, 269);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(189, 27);
            textBox4.TabIndex = 33;
            textBox4.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(189, 269);
            label5.Name = "label5";
            label5.Size = new Size(157, 23);
            label5.TabIndex = 32;
            label5.Text = "Confirm password";
            // 
            // AdminEditPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label1);
            Name = "AdminEditPage";
            Text = "Form3";
            Load += AdminEditPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label6;
        private Button button1;
        private Button button2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label4;
        private Button button3;
        private TextBox textBox4;
        private Label label5;
    }
}
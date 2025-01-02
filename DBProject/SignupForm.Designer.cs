namespace WinFormsApp1
{
    partial class SignupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            button4 = new Button();
            label4 = new Label();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button3 = new Button();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            textBox4 = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.Gray;
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(441, 335);
            button4.Name = "button4";
            button4.Size = new Size(95, 41);
            button4.TabIndex = 22;
            button4.Text = "Sign up";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(325, 275);
            label4.Name = "label4";
            label4.Size = new Size(88, 23);
            label4.TabIndex = 21;
            label4.Text = "User Type";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Passenger", "Admin" });
            comboBox1.Location = new Point(479, 273);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(189, 28);
            comboBox1.TabIndex = 20;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(61, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(479, 169);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(189, 27);
            textBox2.TabIndex = 18;
            textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(479, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 27);
            textBox1.TabIndex = 17;
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(695, 400);
            button3.Name = "button3";
            button3.Size = new Size(95, 35);
            button3.TabIndex = 16;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(325, 173);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 15;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(325, 125);
            label1.Name = "label1";
            label1.Size = new Size(54, 23);
            label1.TabIndex = 14;
            label1.Text = "Email";
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(597, 335);
            button2.Name = "button2";
            button2.Size = new Size(95, 41);
            button2.TabIndex = 13;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(479, 224);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(189, 27);
            textBox3.TabIndex = 24;
            textBox3.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(279, 224);
            label3.Name = "label3";
            label3.Size = new Size(156, 23);
            label3.TabIndex = 23;
            label3.Text = "Confirm Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(297, 0);
            label5.Name = "label5";
            label5.Size = new Size(189, 41);
            label5.TabIndex = 25;
            label5.Text = "Airport App";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(-3, 0);
            label6.Name = "label6";
            label6.Size = new Size(116, 23);
            label6.TabIndex = 26;
            label6.Text = "Sign up Page";
            label6.Click += label6_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(10, 400);
            button1.Name = "button1";
            button1.Size = new Size(103, 35);
            button1.TabIndex = 27;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(479, 67);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(189, 27);
            textBox4.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(325, 72);
            label7.Name = "label7";
            label7.Size = new Size(89, 23);
            label7.TabIndex = 28;
            label7.Text = "Username";
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 449);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Name = "SignupForm";
            Text = "Signin";
            Load += SignupForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Label label4;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button3;
        private Label label2;
        private Label label1;
        private Button button2;
        private TextBox textBox3;
        private Label label3;
        private Label label5;
        private Label label6;
        private Button button1;
        private TextBox textBox4;
        private Label label7;
    }
}
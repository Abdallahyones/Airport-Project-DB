namespace WinFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            button4 = new Button();
            label6 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(363, 320);
            button1.Name = "button1";
            button1.Size = new Size(95, 41);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(488, 320);
            button2.Name = "button2";
            button2.Size = new Size(95, 41);
            button2.TabIndex = 1;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(373, 76);
            label1.Name = "label1";
            label1.Size = new Size(89, 23);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(373, 177);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(695, 400);
            button3.Name = "button3";
            button3.Size = new Size(95, 39);
            button3.TabIndex = 4;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(489, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(488, 177);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(189, 27);
            textBox2.TabIndex = 6;
            textBox2.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(109, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(295, 0);
            label3.Name = "label3";
            label3.Size = new Size(189, 41);
            label3.TabIndex = 8;
            label3.Text = "Airport App";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Passenger", "Admin" });
            comboBox1.Location = new Point(488, 237);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(189, 28);
            comboBox1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(373, 241);
            label4.Name = "label4";
            label4.Size = new Size(88, 23);
            label4.TabIndex = 10;
            label4.Text = "User Type";
            // 
            // button4
            // 
            button4.BackColor = Color.Gray;
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(617, 320);
            button4.Name = "button4";
            button4.Size = new Size(95, 41);
            button4.TabIndex = 11;
            button4.Text = "Sign up ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(-3, 0);
            label6.Name = "label6";
            label6.Size = new Size(99, 23);
            label6.TabIndex = 27;
            label6.Text = "Login Page";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(488, 125);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(189, 27);
            textBox3.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(373, 125);
            label5.Name = "label5";
            label5.Size = new Size(54, 23);
            label5.TabIndex = 28;
            label5.Text = "Email";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 449);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = SystemColors.ControlText;
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private Button button4;
        private Label label6;
        private TextBox textBox3;
        private Label label5;
    }
}
namespace WinFormsApp1
{
    partial class AdminPage
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label6 = new Label();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(177, 182);
            button1.Name = "button1";
            button1.Size = new Size(120, 43);
            button1.TabIndex = 0;
            button1.Text = "Flight";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(335, 182);
            button2.Name = "button2";
            button2.Size = new Size(132, 43);
            button2.TabIndex = 1;
            button2.Text = "Aircraft";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(10, 396);
            button3.Name = "button3";
            button3.Size = new Size(78, 43);
            button3.TabIndex = 2;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(306, -2);
            label1.Name = "label1";
            label1.Size = new Size(189, 41);
            label1.TabIndex = 3;
            label1.Text = "Airport App";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(0, -2);
            label6.Name = "label6";
            label6.Size = new Size(109, 23);
            label6.TabIndex = 15;
            label6.Text = "Admin page";
            // 
            // button4
            // 
            button4.BackColor = Color.Gray;
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(502, 182);
            button4.Name = "button4";
            button4.Size = new Size(120, 43);
            button4.TabIndex = 16;
            button4.Text = "Account";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Gray;
            button5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(711, 396);
            button5.Name = "button5";
            button5.Size = new Size(78, 43);
            button5.TabIndex = 17;
            button5.Text = "Exit";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = SystemColors.ControlText;
            Name = "AdminPage";
            Text = "Admin-Page";
            Load += AdminPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label6;
        private Button button4;
        private Button button5;
    }
}
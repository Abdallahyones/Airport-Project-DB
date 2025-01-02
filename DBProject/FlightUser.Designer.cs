namespace DBProject
{
    partial class FlightUser
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            label9 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(265, 365);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(642, 245);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(265, 264);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(140, 56);
            button1.TabIndex = 12;
            button1.Text = "myFlights";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(768, 264);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(140, 56);
            button2.TabIndex = 14;
            button2.Text = "Flights";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(118, 58);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(104, 32);
            label9.TabIndex = 32;
            label9.Text = "FlightID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(265, 58);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(295, 31);
            textBox1.TabIndex = 31;
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(621, 44);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(226, 56);
            button3.TabIndex = 33;
            button3.Text = "reserve flight";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Gray;
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(621, 114);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(226, 56);
            button4.TabIndex = 34;
            button4.Text = "remove flight";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Gray;
            button5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(15, 654);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(226, 56);
            button5.TabIndex = 35;
            button5.Text = "Back";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Economy", "Premium economy ", "Business", "First class" });
            comboBox1.Location = new Point(265, 114);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(295, 33);
            comboBox1.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(99, 114);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(142, 32);
            label1.TabIndex = 37;
            label1.Text = "Flight Class";
            // 
            // button6
            // 
            button6.BackColor = Color.Gray;
            button6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Location = new Point(265, 166);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(119, 40);
            button6.TabIndex = 38;
            button6.Text = "Edit Class";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // FlightUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1142, 750);
            Controls.Add(button6);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label9);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FlightUser";
            Text = "FlightUser";
            Load += FlightUser_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Label label9;
        private TextBox textBox1;
        private Button button3;
        private Button button4;
        private Button button5;
        private ComboBox comboBox1;
        private Label label1;
        private Button button6;
    }
}
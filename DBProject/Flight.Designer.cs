namespace WinFormsApp1
{
    partial class Flight
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
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            label6 = new Label();
            button5 = new Button();
            button6 = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            textBox1 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBox4 = new TextBox();
            button4 = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(341, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(221, 48);
            label1.TabIndex = 0;
            label1.Text = "Airport App";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 74);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(131, 32);
            label2.TabIndex = 1;
            label2.Text = "Departure";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(658, 134);
            textBox2.Margin = new Padding(4, 4, 4, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(295, 31);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(28, 130);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 32);
            label3.TabIndex = 3;
            label3.Text = "Arrival";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(658, 74);
            textBox3.Margin = new Padding(4, 4, 4, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(295, 31);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(520, 74);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(92, 32);
            label4.TabIndex = 5;
            label4.Text = "Source";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(492, 130);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(146, 32);
            label5.TabIndex = 7;
            label5.Text = "Destination";
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(230, 344);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(101, 56);
            button1.TabIndex = 9;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(190, 436);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(719, 226);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(374, 344);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(101, 56);
            button2.TabIndex = 11;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(501, 344);
            button3.Margin = new Padding(4, 4, 4, 4);
            button3.Name = "button3";
            button3.Size = new Size(101, 56);
            button3.TabIndex = 12;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(0, 0);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(186, 28);
            label6.TabIndex = 14;
            label6.Text = "Flight Admin page";
            // 
            // button5
            // 
            button5.BackColor = Color.Gray;
            button5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(966, 499);
            button5.Margin = new Padding(4, 4, 4, 4);
            button5.Name = "button5";
            button5.Size = new Size(121, 76);
            button5.TabIndex = 15;
            button5.Text = "Exit";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Gray;
            button6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Location = new Point(16, 511);
            button6.Margin = new Padding(4, 4, 4, 4);
            button6.Name = "button6";
            button6.Size = new Size(121, 76);
            button6.TabIndex = 22;
            button6.Text = "Back";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(162, 71);
            dateTimePicker1.Margin = new Padding(2, 4, 2, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 23;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(162, 134);
            dateTimePicker2.Margin = new Padding(2, 4, 2, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(300, 31);
            dateTimePicker2.TabIndex = 24;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(162, 195);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(295, 31);
            textBox1.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(5, 194);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(127, 32);
            label8.TabIndex = 28;
            label8.Text = "AircraftID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(284, 269);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(104, 32);
            label9.TabIndex = 30;
            label9.Text = "FlightID";
            label9.Click += label9_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(428, 269);
            textBox4.Margin = new Padding(4, 4, 4, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(295, 31);
            textBox4.TabIndex = 29;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button4
            // 
            button4.BackColor = Color.Gray;
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(636, 344);
            button4.Margin = new Padding(4, 4, 4, 4);
            button4.Name = "button4";
            button4.Size = new Size(101, 56);
            button4.TabIndex = 31;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Gray;
            button7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button7.ForeColor = SystemColors.ButtonFace;
            button7.Location = new Point(768, 344);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(111, 56);
            button7.TabIndex = 32;
            button7.Text = "Aircrafts";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // Flight
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1102, 696);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(label9);
            Controls.Add(textBox4);
            Controls.Add(label8);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Flight";
            Text = "Flight";
            Load += Flight_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Label label6;
        private Button button5;
        private Button button6;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox1;
        private Label label8;
        private Label label9;
        private TextBox textBox4;
        private Button button4;
        private Button button7;
    }
}

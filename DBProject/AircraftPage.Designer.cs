namespace WinFormsApp1
{
    partial class AircraftPage
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label6 = new Label();
            button5 = new Button();
            button6 = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(273, 0);
            label1.Name = "label1";
            label1.Size = new Size(189, 41);
            label1.TabIndex = 0;
            label1.Text = "Airport App";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(155, 136);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(263, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(263, 187);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(267, 27);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(149, 187);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 3;
            label3.Text = "Capacity";
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(246, 264);
            button1.Name = "button1";
            button1.Size = new Size(81, 41);
            button1.TabIndex = 9;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(155, 311);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(489, 128);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(366, 264);
            button2.Name = "button2";
            button2.Size = new Size(81, 41);
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
            button3.Location = new Point(472, 264);
            button3.Name = "button3";
            button3.Size = new Size(81, 41);
            button3.TabIndex = 12;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Gray;
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(693, 11);
            button4.Name = "button4";
            button4.Size = new Size(97, 29);
            button4.TabIndex = 13;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(-1, 0);
            label6.Name = "label6";
            label6.Size = new Size(117, 23);
            label6.TabIndex = 14;
            label6.Text = "Aircraft page";
            // 
            // button5
            // 
            button5.BackColor = Color.Gray;
            button5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(693, 397);
            button5.Name = "button5";
            button5.Size = new Size(97, 41);
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
            button6.Location = new Point(14, 397);
            button6.Name = "button6";
            button6.Size = new Size(97, 37);
            button6.TabIndex = 16;
            button6.Text = "Back";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(263, 93);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(267, 27);
            textBox3.TabIndex = 18;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(134, 93);
            label4.Name = "label4";
            label4.Size = new Size(108, 28);
            label4.TabIndex = 17;
            label4.Text = "Airport ID";
            // 
            // AircraftPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 449);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AircraftPage";
            Text = "Aircraft-Page";
            Load += AircraftPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label6;
        private Button button5;
        private Button button6;
        private TextBox textBox3;
        private Label label4;
    }
}

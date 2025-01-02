using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{

    public partial class AdminEditPage : Form
    {
        int adminID;
        String ConnectionString = "Data Source=localhost;Initial Catalog=Airport_Project_DB;Integrated Security=True;TrustServerCertificate=True";

        public AdminEditPage()
        {
            InitializeComponent();
        }
        public AdminEditPage(int ID)
        {
            InitializeComponent();
            this.adminID = ID;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                MessageBox.Show("Admin data updated succssefly. ");
                //clearData();
            }
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    string query = "UPDATE Admin SET UserName = @UserName WHERE Admin_id = @Admin_id";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@UserName", textBox1.Text);
                        command.Parameters.AddWithValue("@Admin_id", adminID);
                        command.ExecuteNonQuery();
                    }
                    //   MessageBox.Show("Field edited successfully!");
                    //  showData();
                }
                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    string query = "UPDATE Admin SET Email = @Email WHERE Admin_id = @Admin_id";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@Email", textBox2.Text);
                        command.Parameters.AddWithValue("@Admin_id", adminID);
                        command.ExecuteNonQuery();
                    }
                    //   MessageBox.Show("Field edited successfully!");

                    //  showData();
                }
                if (!string.IsNullOrEmpty(textBox3.Text))
                {
                    string query = "UPDATE Admin SET Password = @Password WHERE Admin_id = @Admin_id";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@Password", textBox3.Text);
                        command.Parameters.AddWithValue("@Admin_id", adminID);
                        command.ExecuteNonQuery();
                    }
                    //   MessageBox.Show("Field edited successfully!");

                    //  showData();
                }
                conn.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage(adminID);
            this.Hide();
            adminPage.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private bool IsValid()
        {
            if (textBox1.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Error ,enter invalid username!");
                return false;
            }
            if (textBox2.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Error ,enter invalid email!");
                return false;
            }
            if (textBox3.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Error ,enter invalid password!");
                return false;
            }
            if (textBox4.Text.TrimStart() == string.Empty || textBox4.Text != textBox3.Text)
            {
                MessageBox.Show("Error ,passwords not match!");
                return false;
            }
            return true;
        }
        private void clearData()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void AdminEditPage_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

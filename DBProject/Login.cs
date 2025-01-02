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

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
        private bool IsValid()
        {
            if (textBox1.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("username!");
                return false;
            }
            if (textBox2.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Error , invalid password!");
                return false;
            }
            if (textBox3.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Error , invalid Email!");
                return false;
            }
            if (comboBox1.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Error , invalid user type!");
                return false;
            }
            return true;
        }
        String connectionString = "Data Source=localhost;Initial Catalog=Airport_Project_DB;Integrated Security=True;TrustServerCertificate=True";
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Admin")
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    conn.Open();
                    String query = "SELECT UserName , Email , Password, Admin_id FROM Admin WHERE UserName = @UserName";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@UserName", textBox1.Text);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int adminID = (int)reader["Admin_id"];
                        String email = reader["Email"].ToString();
                        String password = reader["Password"].ToString();

                        if (!string.IsNullOrEmpty(textBox3.Text) || !string.IsNullOrEmpty(textBox2.Text))
                        {
                            if (textBox3.Text == email && textBox2.Text == password)
                            {

                                AdminPage admin = new AdminPage(adminID);
                                this.Hide();
                                admin.Show();

                            }
                            else { MessageBox.Show("Invalid email or Password"); }
                        }
                    }
                    else { MessageBox.Show("Invalid username"); }
                }
            }
            if (comboBox1.Text == "Passenger")
            {

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT passenger_ID , UserName , Email , Password FROM Passenger WHERE UserName = @UserName";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@UserName", textBox1.Text);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        String email = reader["Email"].ToString();
                        String password = reader["Password"].ToString();
                        int userid = (int)reader["passenger_ID"];
                        if (!string.IsNullOrEmpty(textBox3.Text) || !string.IsNullOrEmpty(textBox2.Text))
                        {
                            if (textBox3.Text == email && textBox2.Text == password)
                            {
                                PassengerPage user = new PassengerPage(userid);
                                this.Hide();
                                user.Show();

                            }
                            else { MessageBox.Show("Invalid email or Password"); }
                        }
                    }
                    else { MessageBox.Show("Invalid username"); }

                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SignupForm signin = new SignupForm();
            this.Hide();
            signin.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

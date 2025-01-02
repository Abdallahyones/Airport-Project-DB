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
    public partial class SignupForm : Form
    {
        String connectionString = "Data Source=localhost;Initial Catalog=Airport_Project_DB;Integrated Security=True;TrustServerCertificate=True";

        public SignupForm()
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
            textBox3.Clear();
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
                MessageBox.Show("Error ,enter invalid password!");
                return false;
            }
            if (textBox3.Text.TrimStart() == string.Empty || textBox3.Text != textBox2.Text)
            {
                MessageBox.Show("Error ,passwords not match!");
                return false;
            }
            if (comboBox1.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Error ,enter invalid user type!");
                return false;
            }
            return true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string userName = textBox4.Text;
                string email = textBox1.Text;
                string password = textBox2.Text;
                string role = comboBox1.Text;

                if (UserExists(userName, email))
                {
                    MessageBox.Show("User already exists :)");
                }
                else
                {
                    InsertUser(userName, email, password, role);
                    if (comboBox1.Text == "Admin")
                    {
                        AdminPage admin = new AdminPage();
                        this.Hide();
                        admin.Show();
                    }
                    if (comboBox1.Text == "Passenger")
                    {
                        PassengerPage user = new PassengerPage();
                        this.Hide();
                        user.Show();
                    }
                }
            }
        }
        private bool UserExists(string userName, string email)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query;
                if (comboBox1.Text == "Admin")
                {
                    query = "SELECT COUNT(*) FROM Admin WHERE UserName = @UserName OR Email = @Email";
                }
                else
                {
                    query = "SELECT COUNT(*) FROM Passenger WHERE UserName = @UserName OR Email = @Email";
                }
                

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                   
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@Email", email);

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void InsertUser(string userName, string email, string password, string role)
        {
            string query;

            if (role == "Admin")
            {
                query = "INSERT INTO Admin (UserName, Email, Password) VALUES (@UserName, @Email, @Password)";
            }
            else
            {
                query = "INSERT INTO Passenger (UserName, Email, Password) VALUES (@UserName, @Email, @Password)";
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        private void UpdateUser(int userId, string newEmail, string newPassword, string role)
        {
            string query;
            if (role == "Admin")
            {
                query = "UPDATE Admin SET Email = @Email, Password = @Password WHERE Admin_id = @UserId";
            }
            else
            {
                query = "UPDATE Passenger SET Email = @Email, Password = @Password WHERE passenger_ID = @UserId";
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@Email", newEmail);
                    cmd.Parameters.AddWithValue("@Password", newPassword);
                    cmd.ExecuteNonQuery();

                }
                conn.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login adminPage = new Login();
            this.Hide();
            adminPage.Show();
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {

        }
    }
}

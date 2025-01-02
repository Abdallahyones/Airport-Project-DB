using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Transactions;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class AircraftPage : Form
    {
        int adminID;
        String ConnectionString = "Data Source=localhost;Initial Catalog=Airport_Project_DB;Integrated Security=True;TrustServerCertificate=True";
        public AircraftPage()
        {
            InitializeComponent();
        }
        public AircraftPage(int ID)
        {
            InitializeComponent();
            showAircraftAdmin();
            adminID = ID;

        }
        private void showAircraftAdmin()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {

                conn.Open();
                String query = "Select Aircraft_ID,Capacity,Aircraft_Name From Aircraft";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter Aircraft ID");
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    String query = "SELECT * FROM Aircraft where Aircraft_ID = @Aircraft_ID;";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@Aircraft_ID", int.Parse(textBox3.Text));

                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;

                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dataGridView1.DataSource = table;
                    }
                    conn.Close();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            this.Hide();
            adminPage.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AircraftPage_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    String query = "SELECT COUNT(*) FROM Aircraft where Aircraft_ID = @Aircraft_ID;";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@Aircraft_ID", int.Parse(textBox3.Text));

                        int count = (int)command.ExecuteScalar();
                        if (count == 1)
                        {
                            MessageBox.Show("Sorry , Aircraft ID is found ");
                        }
                        else
                        {
                            query = "INSERT INTO Aircraft(Aircraft_ID,Capacity,Aircraft_Name)" +
                                   " Values (@Aircraft_ID,@Capacity,@Aircraft_Name)";
                            using (SqlCommand command2 = new SqlCommand(query, conn))
                            {
                                command2.Parameters.AddWithValue("@Aircraft_ID", int.Parse(textBox3.Text));
                                command2.Parameters.AddWithValue("@Aircraft_Name", textBox1.Text);
                                command2.Parameters.AddWithValue("@Capacity", textBox2.Text);

                                command2.ExecuteNonQuery();
                            }
                        }
                    }
                    conn.Close();
                }
                showAircraftAdmin();

            }
        }

        private bool IsValid()
        {
            if (textBox1.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Error ,Enter Valid Name");
                return false;
            }
            if (textBox2.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter  Capacity");
                return false;
            }
            if (textBox3.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter Aircraft ID");
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter Aircraft ID");
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    String query = "SELECT COUNT(*) FROM Aircraft where Aircraft_ID = @Aircraft_ID;";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@Aircraft_ID", int.Parse(textBox3.Text));

                        int count = (int)command.ExecuteScalar();
                        if (count == 0)
                        {
                            MessageBox.Show("Sorry, Aircraft ID is not found");
                        }
                        else
                        {
                            // Delete from Ticket table using FlightID
                            query = "DELETE FROM Ticket WHERE FlightID IN (SELECT FlightID FROM Flight WHERE AircraftID = @Aircraft_ID)";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@Aircraft_ID", int.Parse(textBox3.Text));
                                cmd.ExecuteNonQuery();
                            }

                            // Delete from Flight table using AircraftID
                            query = "DELETE FROM Flight WHERE AircraftID = @Aircraft_ID";
                            using (SqlCommand command2 = new SqlCommand(query, conn))
                            {
                                command2.Parameters.AddWithValue("@Aircraft_ID", int.Parse(textBox3.Text));
                                command2.ExecuteNonQuery();
                            }

                            // Finally, delete from the Aircraft table using Aircraft_ID
                            query = "DELETE FROM Aircraft WHERE Aircraft_ID = @Aircraft_ID";
                            using (SqlCommand command3 = new SqlCommand(query, conn))
                            {
                                command3.Parameters.AddWithValue("@Aircraft_ID", int.Parse(textBox3.Text));
                                command3.ExecuteNonQuery();
                            }
                        }
                    }
                    conn.Close();
                }
                showAircraftAdmin();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    String query = "SELECT COUNT(*) FROM Aircraft where Aircraft_ID = @Aircraft_ID;";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@Aircraft_ID", int.Parse(textBox3.Text));

                        int count = (int)command.ExecuteScalar();
                        if (count == 0)
                        {
                            MessageBox.Show("Sorry , Aircraft ID is not found ");
                        }
                        else
                        {
                            query = "Update Aircraft " +
                                    "set Capacity = @Capacity , Aircraft_Name =@Aircraft_Name "
                                   + "where Aircraft_ID = @Aircraft_ID";
                            using (SqlCommand command2 = new SqlCommand(query, conn))
                            {
                                command2.Parameters.AddWithValue("@Aircraft_ID", int.Parse(textBox3.Text));
                                command2.Parameters.AddWithValue("@Aircraft_Name", textBox1.Text);
                                command2.Parameters.AddWithValue("@Capacity", textBox2.Text);

                                command2.ExecuteNonQuery();
                            }
                            showAircraftAdmin();

                        }
                    }
                    conn.Close();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

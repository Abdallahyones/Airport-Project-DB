using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;


namespace WinFormsApp1
{
    public partial class Flight : Form
    {
        int adminID;
        String ConnectionString = "Data Source=localhost;Initial Catalog=Airport_Project_DB;Integrated Security=True;TrustServerCertificate=True";

        public Flight()
        {
            InitializeComponent();
            showFlightsAdmin();
        }
        public Flight(int ID)
        {
            InitializeComponent();
            this.adminID = ID;
            showFlightsAdmin();
        }
        private bool IsValid()
        {
            if (textBox4.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Error ,Enter Valid FlightID");
                return false;
            }
            if (textBox2.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter  Destination");
                return false;
            }
            if (textBox3.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter Source");
                return false;
            }
            return true;
        }
        private bool find_flightID()
        {
            int count = 0;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                String query = "SELECT COUNT(*) FROM Flight where FlightID = @FlightID;";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@FlightID", int.Parse(textBox4.Text));
                    count = (int)command.ExecuteScalar();

                }
                conn.Close();
            }
            return count > 0;
        }
        private void showFlightsAdmin()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {

                conn.Open();
                String query = "Select FlightID,DepartureDateTime,ArrivalDateTime,Source,Destination,AircraftID From Flight";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
        }
        private void showAircraftsAdmin()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {

                conn.Open();
                String query = "Select * From Aircraft";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage(adminID);
            this.Hide();
            adminPage.Show();
        }

        private void Flight_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (find_flightID())
                {
                    using (SqlConnection conn = new SqlConnection(ConnectionString))
                    {
                        conn.Open();
                        if (!string.IsNullOrEmpty(dateTimePicker1.Text))
                        {
                            string query = "UPDATE Flight SET DepartureDateTime = @DepartureDateTime WHERE FlightID = @FlightID";
                            using (SqlCommand command = new SqlCommand(query, conn))
                            {
                                command.Parameters.AddWithValue("@DepartureDateTime", DateTime.Parse(dateTimePicker1.Text));
                                command.Parameters.AddWithValue("@FlightID", int.Parse(textBox4.Text));

                                command.ExecuteNonQuery();
                            }
                            //   MessageBox.Show("Field edited successfully!");
                            conn.Close();

                            //  showData();
                        }
                    }
                    using (SqlConnection conn = new SqlConnection(ConnectionString))
                    {
                        conn.Open();
                        if (!string.IsNullOrEmpty(dateTimePicker1.Text))
                        {
                            string query = "UPDATE Flight SET ArrivalDateTime = @ArrivalDateTime WHERE FlightID = @FlightID";
                            using (SqlCommand command = new SqlCommand(query, conn))
                            {
                                command.Parameters.AddWithValue("@ArrivalDateTime", DateTime.Parse(dateTimePicker2.Text));
                                command.Parameters.AddWithValue("@FlightID", int.Parse(textBox4.Text));

                                command.ExecuteNonQuery();
                            }
                            //   MessageBox.Show("Field edited successfully!");
                            conn.Close();

                            //  showData();
                        }
                    }
                    using (SqlConnection conn = new SqlConnection(ConnectionString))
                    {
                        conn.Open();
                        if (!string.IsNullOrEmpty(dateTimePicker1.Text))
                        {
                            string query = "UPDATE Flight SET Source = @Source WHERE FlightID = @FlightID";
                            using (SqlCommand command = new SqlCommand(query, conn))
                            {
                                command.Parameters.AddWithValue("@Source", textBox3.Text);
                                command.Parameters.AddWithValue("@FlightID", int.Parse(textBox4.Text));

                                command.ExecuteNonQuery();
                            }
                            //   MessageBox.Show("Field edited successfully!");
                            conn.Close();

                            //  showData();
                        }
                    }
                    using (SqlConnection conn = new SqlConnection(ConnectionString))
                    {
                        conn.Open();
                        if (!string.IsNullOrEmpty(dateTimePicker1.Text))
                        {
                            string query = "UPDATE Flight SET Destination = @Destination WHERE FlightID = @FlightID";
                            using (SqlCommand command = new SqlCommand(query, conn))
                            {
                                command.Parameters.AddWithValue("@Destination", textBox2.Text);
                                command.Parameters.AddWithValue("@FlightID", int.Parse(textBox4.Text));

                                command.ExecuteNonQuery();
                            }
                            //   MessageBox.Show("Field edited successfully!");
                            conn.Close();

                            //  showData();
                        }
                    }
                    showFlightsAdmin();
                }
                else
                {
                    MessageBox.Show("the flight ID is not found");
                }

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (find_flightID())
                {
                    MessageBox.Show("Error ,Enter Valid FlightID");
                }
                else
                {

                    using (SqlConnection conn = new SqlConnection(ConnectionString))
                    {
                        conn.Open();
                        String query = "SELECT COUNT(*) FROM Aircraft where Aircraft_ID = @Aircraft_ID;";

                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@Aircraft_ID", int.Parse(textBox1.Text));

                            int count = (int)command.ExecuteScalar();
                            if (count == 0)
                            {
                                MessageBox.Show("Sorry , Aircraft ID is not found ");
                            }
                            else
                            {

                                object NullAircraft = DBNull.Value;
                                query = "INSERT INTO Flight(FlightID,DepartureDateTime,ArrivalDateTime,Source,Destination,AircraftID)" +
                                    "Values (@FlightID,@DepartureDateTime,@ArrivalDateTime,@Source,@Destination,@AircraftID)";

                                using (SqlCommand command2 = new SqlCommand(query, conn))
                                {
                                    command2.Parameters.AddWithValue("@FlightID", int.Parse(textBox4.Text));
                                    command2.Parameters.AddWithValue("@DepartureDateTime", DateTime.Parse(dateTimePicker1.Text));
                                    command2.Parameters.AddWithValue("@ArrivalDateTime", DateTime.Parse(dateTimePicker2.Text));
                                    command2.Parameters.AddWithValue("@Source", textBox3.Text);
                                    command2.Parameters.AddWithValue("@Destination", textBox2.Text);
                                    command2.Parameters.AddWithValue("@AircraftID", int.Parse(textBox1.Text));

                                    command2.ExecuteNonQuery();
                                    showFlightsAdmin();
                                }
                            }
                        }
                        conn.Close();
                    }
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    if (!string.IsNullOrEmpty(textBox4.Text))
                    {

                        conn.Open();

                        String query = "DELETE FROM Flight WHERE FlightID = @FlightID ";
                        SqlCommand command = new SqlCommand(query, conn);

                        command.Parameters.AddWithValue("@FlightID", int.Parse(textBox4.Text));
                        command.ExecuteNonQuery();

                        showFlightsAdmin();
                        conn.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("FlightID must be Integer");
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    String query = "SELECT FlightID, DepartureDateTime,ArrivalDateTime,Source,Destination,AircraftID FROM Flight WHERE FlightID = @FlightID";

                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@FlightID", int.Parse(textBox4.Text));
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = command;

                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FlightID Field must be Integer");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            showAircraftsAdmin();
        }


    }
}

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
using WinFormsApp1;

namespace DBProject
{
    public partial class FlightUser : Form
    {
        int userId;
        public FlightUser(int user_id)
        {
            InitializeComponent();
            this.userId = user_id;
        }

        String connectionString = "Data Source=localhost;Initial Catalog=Airport_Project_DB;Integrated Security=True;TrustServerCertificate=True";

        private void showFlights()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                String query = "SELECT FlightID,DepartureDateTime,ArrivalDateTime,Source,Destination FROM Flight";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();

                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }
        private void showMyFlights()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                String query = "SELECT f.FlightID,t.Flight_Class,f.DepartureDateTime,f.ArrivalDateTime,f.Source,f.Destination FROM Passenger p JOIN Ticket t ON p.passenger_ID = t.Passenger_ID AND p.passenger_ID = @ID JOIN Flight f ON t.FlightID = f.FlightID ";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@ID", userId);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();

                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }
        //private void UserFlights()
        //{
        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        String query = "Select f.FlightID,f.DepartureDateTime,f.ArrivalDateTime,f.Source,f.Destination, T.Flight_Class " +
        //            "FROM Flight f , Ticket T " +
        //            "WHERE f.FlightID = T.FlightID and Passenger_ID = @Passenger_ID";
        //        using (SqlCommand command = new SqlCommand(query, conn))
        //        {
        //            command.Parameters.AddWithValue("@Passenger_ID", userId);
        //            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
        //            DataTable table = new DataTable();
        //            dataAdapter.Fill(table);

        //            dataGridView1.DataSource = table;
        //        }
        //    }
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            showFlights();
        }  //flight

        private void button1_Click(object sender, EventArgs e)   // my flight
        {
            showMyFlights();
        }
        private void button3_Click(object sender, EventArgs e) // reserve
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Check if FlightID exists
                String checkFlightQuery = "SELECT FlightID FROM Flight WHERE FlightID = @FlightID";
                using (SqlCommand flightCmd = new SqlCommand(checkFlightQuery, conn))
                {
                    flightCmd.Parameters.AddWithValue("@FlightID", int.Parse(textBox1.Text));
                    using (SqlDataReader flightReader = flightCmd.ExecuteReader())
                    {
                        if (!flightReader.HasRows)
                        {
                            MessageBox.Show("Enter Valid flight ID");
                            return; // Exit the function
                        }
                        flightReader.Close();
                    }
                }

                // Check if Passenger_ID exists
                String checkPassengerQuery = "SELECT Passenger_ID FROM Passenger WHERE Passenger_ID = @Passenger_ID";
                using (SqlCommand passengerCmd = new SqlCommand(checkPassengerQuery, conn))
                {
                    passengerCmd.Parameters.AddWithValue("@Passenger_ID", userId);
                    using (SqlDataReader passengerReader = passengerCmd.ExecuteReader())
                    {
                        if (!passengerReader.HasRows)
                        {
                            MessageBox.Show("Enter Valid passenger ID");
                            return; // Exit the function
                        }
                        passengerReader.Close();
                    }
                }

                // Check if the reservation already exists
                string checkExistingReservationQuery = "SELECT COUNT(*) FROM Ticket WHERE Passenger_ID = @Passenger_ID AND FlightID = @FlightID";
                using (SqlCommand checkCmd = new SqlCommand(checkExistingReservationQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@Passenger_ID", userId);
                    checkCmd.Parameters.AddWithValue("@FlightID", int.Parse(textBox1.Text));

                    int result = (int)checkCmd.ExecuteScalar();

                    if (result > 0)
                    {
                        MessageBox.Show("Flight is already reserved before");
                        return; // Exit the function
                    }
                }

                // Insert the reservation into the Ticket table
                string insertQuery = "INSERT INTO Ticket(Passenger_ID, FlightID,Flight_Class) VALUES(@Passenger_ID, @FlightID, @Flight_Class)";
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@Passenger_ID", userId);
                    insertCmd.Parameters.AddWithValue("@FlightID", int.Parse(textBox1.Text));
                    insertCmd.Parameters.AddWithValue("@Flight_Class", comboBox1.Text);
                    insertCmd.ExecuteNonQuery();
                    MessageBox.Show("Reserved successfully");
                    showMyFlights();
                }

                conn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                String CheckQuery = "SELECT FlightID FROM Flight WHERE FlightID = @FlightID";
                using (SqlCommand command = new SqlCommand(CheckQuery, conn))
                {
                    command.Parameters.AddWithValue("@FlightID", int.Parse(textBox1.Text));
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Enter Valid flight ID");
                        }
                        else
                        {
                            reader.Close();

                            string checkExistingReservationQuery = "SELECT COUNT(*) FROM Ticket WHERE Passenger_ID = @Passenger_ID AND FlightID = @FlightID";
                            using (SqlCommand command2 = new SqlCommand(checkExistingReservationQuery, conn))
                            {
                                command2.Parameters.AddWithValue("@Passenger_ID", userId);
                                command2.Parameters.AddWithValue("@FlightID", int.Parse(textBox1.Text));

                                int result = (int)command2.ExecuteScalar();

                                if (result == 0)
                                {
                                    MessageBox.Show("Flight is already remove before");
                                }
                                else
                                {
                                    String query = "DELETE FROM Ticket WHERE FlightID = @FlightID AND Passenger_ID = @userID";
                                    using (SqlCommand command1 = new SqlCommand(query, conn))
                                    {
                                        command1.Parameters.AddWithValue("@FlightID", int.Parse(textBox1.Text));
                                        command1.Parameters.AddWithValue("@userID", userId);
                                        command1.ExecuteNonQuery();
                                        MessageBox.Show("Remove successfully");
                                        showMyFlights();
                                    }
                                }
                            }


                        }
                        conn.Close();
                    }

                }

            }

        }

        private void FlightUser_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            PassengerPage PassengerPage = new PassengerPage(userId);
            this.Hide();
            PassengerPage.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    String query = "UPDATE Ticket " +
                        "SET Flight_Class = @Flight_Class " +
                        "WHERE Passenger_ID = @Passenger_ID AND FlightID = @FlightID";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@Flight_Class", comboBox1.Text);
                        command.Parameters.AddWithValue("@Passenger_ID", userId);
                        command.Parameters.AddWithValue("@FlightID", int.Parse(textBox1.Text));
                        command.ExecuteNonQuery();
                        //UserFlights();
                        showMyFlights();
                    }
                }
            }
            catch (Exception) { }
        }
    }
}

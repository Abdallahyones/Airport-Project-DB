using DBProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class PassengerPage : Form
    {
        int userID;
        public PassengerPage()
        {
            InitializeComponent();
        }
        public PassengerPage(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FlightUser flight = new FlightUser(userID);
            this.Hide();
            flight.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AircraftPage form = new AircraftPage();
            this.Hide();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PassengerAcc passengeracc = new PassengerAcc(userID);
            this.Hide();
            passengeracc.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void PassengerPage_Load(object sender, EventArgs e)
        {

        }
    }
}

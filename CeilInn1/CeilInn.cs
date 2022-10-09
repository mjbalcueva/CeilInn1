using System;
using System.IO;
using System.Windows.Forms;

namespace CeilInn1
{
    public partial class CeilInn : Form
    {
        private const string Path = @"assets\";

        public CeilInn() => InitializeComponent();

        private void CeilInn_Load(object sender, EventArgs e) => Directory.CreateDirectory(Path);

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            Customers clients = new Customers();
            clients.Show();
        }

        private void BtnOccupancies_Click(object sender, EventArgs e)
        {
            Occupancies rentals = new Occupancies();
            rentals.Show();
        }

        private void BtnRooms_Click(object sender, EventArgs e)
        {
            Rooms rms = new Rooms();
            rms.Show();
        }

        private void BtnPayments_Click(object sender, EventArgs e)
        {
            Payments pmts = new Payments();
            pmts.Show();
        }

        private void BtnEmployees_Click(object sender, EventArgs e)
        {
            Employees staff = new Employees();
            staff.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();
    }
}
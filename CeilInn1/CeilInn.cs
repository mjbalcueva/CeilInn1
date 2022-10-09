using System;
using System.IO;
using System.Windows.Forms;

namespace CeilInn1
{
    public partial class CeilInn : Form
    {
        private const string Path = @"assets\";

        public CeilInn()
        {
            InitializeComponent();
        }

        private void CeilInn_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Path);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Customers clients = new Customers();
            clients.Show();
        }

        private void btnOccupancies_Click(object sender, EventArgs e)
        {
            Occupancies rentals = new Occupancies();
            rentals.Show();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            Rooms rms = new Rooms();
            rms.Show();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            Payments pmts = new Payments();
            pmts.Show();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            Employees staff = new Employees();
            staff.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
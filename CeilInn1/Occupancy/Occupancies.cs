using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace CeilInn1
{
    public partial class Occupancies : Form
    {
        private const string PathRooms = @"assets\Rooms.rms";
        private const string PathCustomers = @"assets\Customers.cst";
        private const string PathEmployees = @"assets\Employees.mpl";
        private const string PathOccupancies = @"assets\Occupancies.ocp";

        public Occupancies()
        {
            InitializeComponent();
        }

        private void ShowOccupancies()
        {
            Collection<Employee> lstEmployees;
            BinaryFormatter bfRooms = new BinaryFormatter();
            Collection<Room> lstRooms = new Collection<Room>();
            BinaryFormatter bfEmployees = new BinaryFormatter();
            BinaryFormatter bfCustomers = new BinaryFormatter();
            BinaryFormatter bfOccupancies = new BinaryFormatter();
            string strEmployee = "", strCustomer = "", strRoom = "";
            Collection<Customer> lstCustomers = new Collection<Customer>();
            Collection<Occupancy> lstOccupancies = new Collection<Occupancy>();
            string strRoomsFile = PathRooms;
            string strCustomersFile = PathCustomers;
            string strEmployeesFile = PathEmployees;
            string strOccupanciesFile = PathOccupancies;

            if (File.Exists(strOccupanciesFile) == true)
            {
                using (FileStream fsOccupancies = new FileStream(strOccupanciesFile,
                                                         FileMode.Open,
                                                     FileAccess.Read))
                {
                    lstOccupancies = (Collection<Occupancy>)bfOccupancies.Deserialize(fsOccupancies);

                    lvwOccupancies.Items.Clear();

                    foreach (Occupancy order in lstOccupancies)
                    {
                        ListViewItem lviOccupancy = new ListViewItem(order.OccupancyNumber.ToString());

                        lviOccupancy.SubItems.Add(order.DateOccupied.ToLongDateString());
                        using (FileStream fsEmployees = new FileStream(strEmployeesFile,
                                                                       FileMode.Open,
                                                                       FileAccess.Read))
                        {
                            lstEmployees = (Collection<Employee>)bfEmployees.Deserialize(fsEmployees);

                            foreach (Employee clerk in lstEmployees)
                            {
                                if (clerk.EmployeeNumber == order.ProcessedBy)
                                    strEmployee = clerk.EmployeeNumber + ": " +
                                                  clerk.FirstName + " " +
                                                  clerk.LastName;
                            }
                        }

                        lviOccupancy.SubItems.Add(strEmployee);

                        using (FileStream fsCustomers = new FileStream(strCustomersFile,
                                                                       FileMode.Open,
                                                                       FileAccess.Read))
                        {
                            lstCustomers = (Collection<Customer>)bfCustomers.Deserialize(fsCustomers);

                            foreach (Customer client in lstCustomers)
                            {
                                if (client.AccountNumber == order.ProcessedFor)
                                    strCustomer = client.AccountNumber + ": " +
                                                  client.FirstName + " " +
                                                  client.LastName;
                            }
                        }

                        lviOccupancy.SubItems.Add(strCustomer);

                        if (File.Exists(strRoomsFile) == true)
                        {
                            using (FileStream fsRooms = new FileStream(strRoomsFile,
                                                                           FileMode.Open,
                                                                           FileAccess.Read))
                            {
                                lstRooms = (Collection<Room>)bfRooms.Deserialize(fsRooms);

                                foreach (Room rm in lstRooms)
                                    if (rm.RoomNumber == order.RoomOccupied)
                                        strRoom = rm.RoomNumber + ": " +
                                                  rm.RoomType + ", " +
                                                  rm.BedType + ", " +
                                                  rm.Rate.ToString("F") + "/day";
                            }
                        }
                        lviOccupancy.SubItems.Add(strRoom);
                        lviOccupancy.SubItems.Add(order.RateApplied.ToString("F"));
                        lviOccupancy.SubItems.Add(order.PhoneUse.ToString("F"));

                        lvwOccupancies.Items.Add(lviOccupancy);
                    }
                }
            }
        }

        private void Occupancies_Load(object sender, EventArgs e)
        {
            ShowOccupancies();
        }

        private void btnNewOccupancy_Click(object sender, EventArgs e)
        {
            OccupancyEditor editor = new OccupancyEditor();
            BinaryFormatter bfmOccupancies = new BinaryFormatter();
            Collection<Occupancy> lstOccupancies = new Collection<Occupancy>();

            string strFileName = PathOccupancies;

            if (File.Exists(strFileName) == true)
            {
                using (FileStream fsOccupancies = new FileStream(strFileName,
                                                            FileMode.Open,
                                                            FileAccess.Read))
                {
                    lstOccupancies = (Collection<Occupancy>)bfmOccupancies.Deserialize(fsOccupancies);
                }
            }

            if (editor.ShowDialog() == DialogResult.OK)
            {
                Occupancy occupy = new Occupancy();

                occupy.OccupancyNumber = int.Parse(editor.txtOccupancyNumber.Text);
                occupy.DateOccupied = editor.dtpDateOccupied.Value;
                occupy.ProcessedBy = editor.txtEmployeeNumber.Text;
                occupy.ProcessedFor = editor.txtAccountNumber.Text;
                occupy.RoomOccupied = editor.txtRoomNumber.Text;
                occupy.RateApplied = double.Parse(editor.txtRateApplied.Text);
                occupy.PhoneUse = double.Parse(editor.txtPhoneUse.Text);

                lstOccupancies.Add(occupy);

                using (FileStream fsOccupancies = new FileStream(strFileName,
                                                            FileMode.Create,
                                                            FileAccess.Write))
                {
                    bfmOccupancies.Serialize(fsOccupancies, lstOccupancies);
                }
            }

            ShowOccupancies();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
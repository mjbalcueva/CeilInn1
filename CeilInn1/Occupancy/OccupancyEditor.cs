using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace CeilInn1
{
    public partial class OccupancyEditor : Form
    {
        private const string PathOccupancies = @"assets\Occupancies.ocp";
        private const string PathEmployees = @"assets\Employees.mpl";
        private const string PathCustomers = @"assets\Customers.cst";
        private const string PathRooms = @"assets\Rooms.rms";

        public OccupancyEditor() => InitializeComponent();

        private void OccupancyEditor_Load(object sender, EventArgs e)
        {
            int iOccupancyNumber = 100000;
            BinaryFormatter bfOccupancies = new BinaryFormatter();
            Collection<Occupancy> lstOccupancies = new Collection<Occupancy>();
            string strOccupanciesFile = PathOccupancies;

            if (File.Exists(strOccupanciesFile))
            {
                using (FileStream fsOccupancies = new FileStream(strOccupanciesFile,
                                                         FileMode.Open,
                                                     FileAccess.Read))
                {
                    lstOccupancies = (Collection<Occupancy>)bfOccupancies.Deserialize(fsOccupancies);

                    foreach (Occupancy order in lstOccupancies)
                    {
                        iOccupancyNumber = order.OccupancyNumber;
                    }
                }
            }

            txtOccupancyNumber.Text = (iOccupancyNumber + 1).ToString();
        }

        private void TxtEmployeeNumber_Leave(object sender, EventArgs e)
        {
            Collection<Employee> lstEmployees;
            BinaryFormatter bfEmployees = new BinaryFormatter();
            string strFileName = PathEmployees;

            if (File.Exists(strFileName))
            {
                using (FileStream fsEmployees = new FileStream(strFileName,
                                                               FileMode.Open,
                                                               FileAccess.Read))
                {
                    lstEmployees = (Collection<Employee>)bfEmployees.Deserialize(fsEmployees);

                    foreach (Employee empl in lstEmployees)
                    {
                        if (empl.EmployeeNumber == txtEmployeeNumber.Text)
                            txtEmployeeName.Text = empl.LastName + ", " + empl.FirstName;
                    }
                }
            }
        }

        private void TxtAccountNumber_Leave(object sender, EventArgs e)
        {
            BinaryFormatter bfCustomers = new BinaryFormatter();
            Collection<Customer> lstCustomers = new Collection<Customer>();
            string strFileName = PathCustomers;

            if (File.Exists(strFileName))
            {
                using (FileStream fsCustomers = new FileStream(strFileName,
                                                                FileMode.Open,
                                                                FileAccess.Read))
                {
                    lstCustomers = (Collection<Customer>)bfCustomers.Deserialize(fsCustomers);

                    foreach (Customer client in lstCustomers)
                    {
                        if (client.AccountNumber == txtAccountNumber.Text)
                            txtCustomerName.Text = client.LastName + ", " + client.FirstName;
                    }
                }
            }
        }

        private void TxtRoomNumber_Leave(object sender, EventArgs e)
        {
            BinaryFormatter bfRooms = new BinaryFormatter();
            Collection<Room> lstRooms = new Collection<Room>();
            string strFileName = PathRooms;

            if (File.Exists(strFileName))
            {
                using (FileStream fsRooms = new FileStream(strFileName,
                                                               FileMode.Open,
                                                               FileAccess.Read))
                {
                    lstRooms = (Collection<Room>)bfRooms.Deserialize(fsRooms);

                    foreach (Room rm in lstRooms)
                    {
                        if (rm.RoomNumber == txtRoomNumber.Text)
                            txtRoomDescription.Text = "Room type: " + rm.RoomType +
                                                      ", Bed type: " + rm.BedType +
                                                      ", Rate = " + rm.Rate.ToString("F") + "/night";
                    }
                }
            }
        }
    }
}
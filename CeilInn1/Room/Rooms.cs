using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace CeilInn1
{
    public partial class Rooms : Form
    {
        private const string PathRooms = @"assets\Rooms.rms";

        public Rooms() => InitializeComponent();

        private void ShowRooms()
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

                    lvwRooms.Items.Clear();

                    foreach (Room rm in lstRooms)
                    {
                        ListViewItem lviRoom = new ListViewItem(rm.RoomNumber);

                        lviRoom.SubItems.Add(rm.RoomType);
                        lviRoom.SubItems.Add(rm.BedType);
                        lviRoom.SubItems.Add(rm.Rate.ToString("F"));
                        lviRoom.SubItems.Add(rm.OccupancyStatus);

                        lvwRooms.Items.Add(lviRoom);
                    }
                }
            }
        }

        private void Rooms_Load(object sender, EventArgs e) => ShowRooms();

        private void BtnNewRoom_Click(object sender, EventArgs e)
        {
            RoomEditor editor = new RoomEditor();
            BinaryFormatter bfRooms = new BinaryFormatter();
            Collection<Room> lstRooms = new Collection<Room>();

            string strFileName = PathRooms;

            if (File.Exists(strFileName))
            {
                using (FileStream fsRooms = new FileStream(strFileName,
                                                        FileMode.Open,
                                                        FileAccess.Read))
                {
                    // Store the list of customers in the collection
                    lstRooms = (Collection<Room>)bfRooms.Deserialize(fsRooms);
                }  // Close the file stream
            }

            if (editor.ShowDialog() == DialogResult.OK)
            {
                Room rm = new Room
                {
                    RoomNumber = editor.txtRoomNumber.Text,
                    RoomType = editor.cbxRoomTypes.Text,
                    BedType = editor.cbxBedTypes.Text,
                    Rate = double.Parse(editor.txtRate.Text),
                    OccupancyStatus = editor.cbxOccupanciesStatus.Text
                };
                lstRooms.Add(rm);

                using (FileStream fsCustomers = new FileStream(strFileName,
                                                            FileMode.Create,
                                                            FileAccess.Write))
                {
                    // Serialize the list of properties
                    bfRooms.Serialize(fsCustomers, lstRooms);
                }

                // Show the list of properties
                ShowRooms();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();
    }
}
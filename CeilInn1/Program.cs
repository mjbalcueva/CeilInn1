using System;
using System.Windows.Forms;

namespace CeilInn1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new CustomerEditor());
            //Application.Run(new EmployeeEditor());
            //Application.Run(new RoomEditor());
            //Application.Run(new OccupancyEditor());
            //Application.Run(new PaymentEditor());
            Application.Run(new Customers());
        }
    }
}
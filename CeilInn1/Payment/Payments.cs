using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace CeilInn1
{
    public partial class Payments : Form
    {
        private const string PathPayments = @"assets\Payments.pmt";
        private const string PathCustomers = @"assets\Customers.cst";
        private const string PathEmployees = @"assets\Employees.mpl";

        public Payments() => InitializeComponent();

        private void ShowPayments()
        {
            Collection<Employee> employees;
            PaymentEditor editor = new PaymentEditor();
            BinaryFormatter bfPayments = new BinaryFormatter();
            BinaryFormatter bfEmployees = new BinaryFormatter();
            BinaryFormatter bfCustomers = new BinaryFormatter();
            string strEmployee = "", strCustomer = "";
            Collection<Payment> payments = new Collection<Payment>();
            Collection<Customer> customers = new Collection<Customer>();
            string strPaymentsFile = PathPayments;
            string strCustomersFile = PathCustomers;
            string strEmployeesFile = PathEmployees;

            if (File.Exists(strPaymentsFile))
            {
                using (FileStream fsPayments = new FileStream(strPaymentsFile,
                                                              FileMode.Open,
                                                              FileAccess.Read))
                {
                    payments = (Collection<Payment>)bfPayments.Deserialize(fsPayments);

                    lvwPayments.Items.Clear();

                    foreach (Payment pmt in payments)
                    {
                        ListViewItem lviPayment = new ListViewItem(pmt.ReceiptNumber.ToString());

                        using (FileStream fsEmployees = new FileStream(strEmployeesFile,
                                                                       FileMode.Open,
                                                                       FileAccess.Read))
                        {
                            employees = (Collection<Employee>)bfEmployees.Deserialize(fsEmployees);

                            foreach (Employee clerk in employees)
                            {
                                if (clerk.EmployeeNumber == pmt.EmployeeNumber)
                                    strEmployee = clerk.EmployeeNumber + ": " +
                                                  clerk.FirstName + " " +
                                                  clerk.LastName;
                            }
                        }

                        lviPayment.SubItems.Add(strEmployee);

                        lviPayment.SubItems.Add(pmt.PaymentDate.ToLongDateString());

                        using (FileStream fsCustomers = new FileStream(strCustomersFile,
                                                                       FileMode.Open,
                                                                       FileAccess.Read))
                        {
                            customers = (Collection<Customer>)bfCustomers.Deserialize(fsCustomers);

                            foreach (Customer client in customers)
                            {
                                if (client.AccountNumber == pmt.AccountNumber)
                                    strCustomer = client.AccountNumber + ": " +
                                                  client.FirstName + " " +
                                                  client.LastName;
                            }
                        }

                        lviPayment.SubItems.Add(strCustomer);
                        lviPayment.SubItems.Add(pmt.FirstDayOccupied.ToLongDateString());
                        lviPayment.SubItems.Add(pmt.LastDayOccupied.ToLongDateString());
                        lviPayment.SubItems.Add(pmt.TotalNights.ToString());
                        lviPayment.SubItems.Add(pmt.AmountCharged.ToString("F"));
                        lviPayment.SubItems.Add(pmt.PhoneUse.ToString("F"));
                        lviPayment.SubItems.Add(pmt.SubTotal.ToString("F"));
                        lviPayment.SubItems.Add((pmt.TaxRate / 100).ToString("P"));
                        lviPayment.SubItems.Add(pmt.TaxAmount.ToString("F"));
                        lviPayment.SubItems.Add(pmt.TotalAmountPaid.ToString("F"));
                        lvwPayments.Items.Add(lviPayment);
                    }
                }
            }
        }

        private void Payments_Load(object sender, EventArgs e) => ShowPayments();

        private void BtnNewPayment_Click(object sender, EventArgs e)
        {
            PaymentEditor editor = new PaymentEditor();
            BinaryFormatter bfPayments = new BinaryFormatter();
            Collection<Payment> payments = new Collection<Payment>();
            string strPaymentsFile = PathPayments;

            if (editor.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(strPaymentsFile))
                {
                    using (FileStream fsPayments = new FileStream(strPaymentsFile,
                                                                    FileMode.Open,
                                                                    FileAccess.Read))
                    {
                        payments = (Collection<Payment>)bfPayments.Deserialize(fsPayments);
                    }
                }

                Payment pmt = new Payment
                {
                    ReceiptNumber = int.Parse(editor.txtReceiptNumber.Text),
                    EmployeeNumber = editor.txtEmployeeNumber.Text,
                    PaymentDate = editor.dtpPaymentDate.Value,
                    AccountNumber = editor.txtAccountNumber.Text,
                    FirstDayOccupied = editor.dtpFirstDateOccupied.Value,
                    LastDayOccupied = editor.dtpLastDateOccupied.Value,
                    TotalNights = int.Parse(editor.txtTotalNights.Text),
                    AmountCharged = double.Parse(editor.txtAmountCharged.Text),
                    PhoneUse = double.Parse(editor.txtPhoneUse.Text),
                    SubTotal = double.Parse(editor.txtSubTotal.Text),
                    TaxRate = double.Parse(editor.txtTaxRate.Text),
                    TaxAmount = double.Parse(editor.txtTaxAmount.Text),
                    TotalAmountPaid = double.Parse(editor.txtTotalAmountPaid.Text)
                };

                payments.Add(pmt);

                using (FileStream fsPayments = new FileStream(strPaymentsFile,
                                                                FileMode.Create,
                                                                FileAccess.Write))
                {
                    bfPayments.Serialize(fsPayments, payments);
                }
            }

            ShowPayments();
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();
    }
}
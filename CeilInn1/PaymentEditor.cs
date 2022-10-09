using System;
using System.Windows.Forms;

namespace CeilInn1
{
    public partial class PaymentEditor : Form
    {
        public PaymentEditor()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // If there is no payment amount, don't do anything
            if (string.IsNullOrEmpty(txtAmountCharged.Text))
                return;

            txtSubTotal.Text = ((Convert.ToInt16(txtTotalNights.Text) * Convert.ToDouble(txtAmountCharged.Text)) + Convert.ToDouble(txtPhoneUse.Text)).ToString("F");
            txtTaxAmount.Text = (Convert.ToDouble(txtSubTotal.Text) * Convert.ToDouble(txtTaxRate.Text) / 100).ToString("F");
            txtTotalAmountPaid.Text = (Convert.ToDouble(txtSubTotal.Text) + Convert.ToDouble(txtTaxAmount.Text)).ToString("F");
        }
    }
}
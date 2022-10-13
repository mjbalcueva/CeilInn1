namespace CeilInn1
{
    partial class PaymentEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtReceiptNumber = new System.Windows.Forms.TextBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtEmployeeNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtAccountDetails = new System.Windows.Forms.TextBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.lblReceiptNumber = new System.Windows.Forms.Label();
            this.lblRoomOccupiedFrom = new System.Windows.Forms.Label();
            this.dtpFirstDateOccupied = new System.Windows.Forms.DateTimePicker();
            this.dtpLastDateOccupied = new System.Windows.Forms.DateTimePicker();
            this.lblLastDateOccupied = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalNights = new System.Windows.Forms.TextBox();
            this.txtAmountCharged = new System.Windows.Forms.TextBox();
            this.lblAmountCharged = new System.Windows.Forms.Label();
            this.txtTaxRate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtTotalAmountPaid = new System.Windows.Forms.TextBox();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.txtTaxAmount = new System.Windows.Forms.TextBox();
            this.lblTaxAmount = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.txtPhoneUse = new System.Windows.Forms.TextBox();
            this.lblPhoneUse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtReceiptNumber
            // 
            this.txtReceiptNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.txtReceiptNumber.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtReceiptNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.txtReceiptNumber.Location = new System.Drawing.Point(126, 626);
            this.txtReceiptNumber.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtReceiptNumber.Name = "txtReceiptNumber";
            this.txtReceiptNumber.Size = new System.Drawing.Size(91, 27);
            this.txtReceiptNumber.TabIndex = 46;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.txtAccountNumber.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAccountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.txtAccountNumber.Location = new System.Drawing.Point(195, 144);
            this.txtAccountNumber.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(91, 27);
            this.txtAccountNumber.TabIndex = 31;
            this.txtAccountNumber.Leave += new System.EventHandler(this.TxtAccountNumber_Leave);
            // 
            // txtEmployeeNumber
            // 
            this.txtEmployeeNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.txtEmployeeNumber.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmployeeNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.txtEmployeeNumber.Location = new System.Drawing.Point(195, 86);
            this.txtEmployeeNumber.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtEmployeeNumber.Name = "txtEmployeeNumber";
            this.txtEmployeeNumber.Size = new System.Drawing.Size(91, 27);
            this.txtEmployeeNumber.TabIndex = 28;
            this.txtEmployeeNumber.Leave += new System.EventHandler(this.TxtEmployeeNumber_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.label11.Location = new System.Drawing.Point(12, 596);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(501, 19);
            this.label11.TabIndex = 39;
            this.label11.Text = "_________________________________________________________________________________" +
    "_";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(29)))), ((int)(((byte)(72)))));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(29)))), ((int)(((byte)(72)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnCancel.Location = new System.Drawing.Point(402, 623);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 32);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(51)))), ((int)(((byte)(234)))));
            this.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(51)))), ((int)(((byte)(234)))));
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnOK.Location = new System.Drawing.Point(297, 623);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(99, 32);
            this.btnOK.TabIndex = 41;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // txtAccountDetails
            // 
            this.txtAccountDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.txtAccountDetails.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAccountDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.txtAccountDetails.Location = new System.Drawing.Point(195, 183);
            this.txtAccountDetails.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtAccountDetails.Name = "txtAccountDetails";
            this.txtAccountDetails.Size = new System.Drawing.Size(298, 27);
            this.txtAccountDetails.TabIndex = 45;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAccountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.lblAccountNumber.Location = new System.Drawing.Point(81, 150);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(83, 19);
            this.lblAccountNumber.TabIndex = 30;
            this.lblAccountNumber.Text = "Account #:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(15, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(490, 19);
            this.label6.TabIndex = 29;
            this.label6.Text = "Processed for Customer ____________________________________________________";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.txtEmployeeName.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmployeeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.txtEmployeeName.Location = new System.Drawing.Point(297, 86);
            this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(193, 27);
            this.txtEmployeeName.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(81, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "Employee #:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(486, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Payment Processed by _____________________________________________________";
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpPaymentDate.Location = new System.Drawing.Point(195, 28);
            this.dtpPaymentDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(298, 27);
            this.dtpPaymentDate.TabIndex = 25;
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPaymentDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.lblPaymentDate.Location = new System.Drawing.Point(15, 28);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(112, 19);
            this.lblPaymentDate.TabIndex = 24;
            this.lblPaymentDate.Text = "Payment Date:";
            // 
            // lblReceiptNumber
            // 
            this.lblReceiptNumber.AutoSize = true;
            this.lblReceiptNumber.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblReceiptNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.lblReceiptNumber.Location = new System.Drawing.Point(12, 632);
            this.lblReceiptNumber.Name = "lblReceiptNumber";
            this.lblReceiptNumber.Size = new System.Drawing.Size(77, 19);
            this.lblReceiptNumber.TabIndex = 40;
            this.lblReceiptNumber.Text = "Receipt #:";
            // 
            // lblRoomOccupiedFrom
            // 
            this.lblRoomOccupiedFrom.AutoSize = true;
            this.lblRoomOccupiedFrom.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRoomOccupiedFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.lblRoomOccupiedFrom.Location = new System.Drawing.Point(15, 225);
            this.lblRoomOccupiedFrom.Name = "lblRoomOccupiedFrom";
            this.lblRoomOccupiedFrom.Size = new System.Drawing.Size(163, 19);
            this.lblRoomOccupiedFrom.TabIndex = 47;
            this.lblRoomOccupiedFrom.Text = "Room Occupied From:";
            // 
            // dtpFirstDateOccupied
            // 
            this.dtpFirstDateOccupied.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpFirstDateOccupied.Location = new System.Drawing.Point(195, 222);
            this.dtpFirstDateOccupied.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dtpFirstDateOccupied.Name = "dtpFirstDateOccupied";
            this.dtpFirstDateOccupied.Size = new System.Drawing.Size(298, 27);
            this.dtpFirstDateOccupied.TabIndex = 48;
            // 
            // dtpLastDateOccupied
            // 
            this.dtpLastDateOccupied.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpLastDateOccupied.Location = new System.Drawing.Point(195, 261);
            this.dtpLastDateOccupied.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dtpLastDateOccupied.Name = "dtpLastDateOccupied";
            this.dtpLastDateOccupied.Size = new System.Drawing.Size(298, 27);
            this.dtpLastDateOccupied.TabIndex = 50;
            // 
            // lblLastDateOccupied
            // 
            this.lblLastDateOccupied.AutoSize = true;
            this.lblLastDateOccupied.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLastDateOccupied.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.lblLastDateOccupied.Location = new System.Drawing.Point(147, 261);
            this.lblLastDateOccupied.Name = "lblLastDateOccupied";
            this.lblLastDateOccupied.Size = new System.Drawing.Size(29, 19);
            this.lblLastDateOccupied.TabIndex = 49;
            this.lblLastDateOccupied.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(16, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 19);
            this.label1.TabIndex = 51;
            this.label1.Text = "Payment _____________________________________________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(255, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 52;
            this.label2.Text = "Total Nights:";
            // 
            // txtTotalNights
            // 
            this.txtTotalNights.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.txtTotalNights.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotalNights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.txtTotalNights.Location = new System.Drawing.Point(363, 300);
            this.txtTotalNights.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtTotalNights.Name = "txtTotalNights";
            this.txtTotalNights.Size = new System.Drawing.Size(70, 27);
            this.txtTotalNights.TabIndex = 53;
            this.txtTotalNights.Text = "1";
            this.txtTotalNights.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAmountCharged
            // 
            this.txtAmountCharged.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.txtAmountCharged.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAmountCharged.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.txtAmountCharged.Location = new System.Drawing.Point(363, 349);
            this.txtAmountCharged.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtAmountCharged.Name = "txtAmountCharged";
            this.txtAmountCharged.Size = new System.Drawing.Size(73, 27);
            this.txtAmountCharged.TabIndex = 55;
            this.txtAmountCharged.Text = "0.00";
            this.txtAmountCharged.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAmountCharged
            // 
            this.lblAmountCharged.AutoSize = true;
            this.lblAmountCharged.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAmountCharged.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.lblAmountCharged.Location = new System.Drawing.Point(255, 355);
            this.lblAmountCharged.Name = "lblAmountCharged";
            this.lblAmountCharged.Size = new System.Drawing.Size(105, 19);
            this.lblAmountCharged.TabIndex = 54;
            this.lblAmountCharged.Text = "Amt Charged:";
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.txtTaxRate.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTaxRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.txtTaxRate.Location = new System.Drawing.Point(348, 487);
            this.txtTaxRate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.Size = new System.Drawing.Size(88, 27);
            this.txtTaxRate.TabIndex = 57;
            this.txtTaxRate.Text = "7.70";
            this.txtTaxRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(231, 491);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 56;
            this.label7.Text = "Tax Rate:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(51)))), ((int)(((byte)(234)))));
            this.btnCalculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btnCalculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(51)))), ((int)(((byte)(234)))));
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnCalculate.Location = new System.Drawing.Point(235, 427);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(201, 32);
            this.btnCalculate.TabIndex = 58;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // txtTotalAmountPaid
            // 
            this.txtTotalAmountPaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.txtTotalAmountPaid.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotalAmountPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.txtTotalAmountPaid.Location = new System.Drawing.Point(348, 565);
            this.txtTotalAmountPaid.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtTotalAmountPaid.Name = "txtTotalAmountPaid";
            this.txtTotalAmountPaid.Size = new System.Drawing.Size(88, 27);
            this.txtTotalAmountPaid.TabIndex = 62;
            this.txtTotalAmountPaid.Text = "0.00";
            this.txtTotalAmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAmountPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.lblAmountPaid.Location = new System.Drawing.Point(234, 569);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(104, 19);
            this.lblAmountPaid.TabIndex = 61;
            this.lblAmountPaid.Text = "Amount Paid:";
            // 
            // txtTaxAmount
            // 
            this.txtTaxAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.txtTaxAmount.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTaxAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.txtTaxAmount.Location = new System.Drawing.Point(348, 526);
            this.txtTaxAmount.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtTaxAmount.Name = "txtTaxAmount";
            this.txtTaxAmount.Size = new System.Drawing.Size(88, 27);
            this.txtTaxAmount.TabIndex = 60;
            this.txtTaxAmount.Text = "0.00";
            this.txtTaxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTaxAmount
            // 
            this.lblTaxAmount.AutoSize = true;
            this.lblTaxAmount.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTaxAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.lblTaxAmount.Location = new System.Drawing.Point(231, 530);
            this.lblTaxAmount.Name = "lblTaxAmount";
            this.lblTaxAmount.Size = new System.Drawing.Size(96, 19);
            this.lblTaxAmount.TabIndex = 59;
            this.lblTaxAmount.Text = "Tax Amount:";
            this.lblTaxAmount.Click += new System.EventHandler(this.lblTaxAmount_Click);
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.lblPercent.Location = new System.Drawing.Point(442, 490);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(22, 19);
            this.lblPercent.TabIndex = 63;
            this.lblPercent.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(441, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 19);
            this.label8.TabIndex = 64;
            this.label8.Text = "/night";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.txtSubTotal.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.txtSubTotal.Location = new System.Drawing.Point(363, 388);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(73, 27);
            this.txtSubTotal.TabIndex = 66;
            this.txtSubTotal.Text = "0.00";
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.lblSubTotal.Location = new System.Drawing.Point(255, 394);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(78, 19);
            this.lblSubTotal.TabIndex = 65;
            this.lblSubTotal.Text = "Sub-Total:";
            // 
            // txtPhoneUse
            // 
            this.txtPhoneUse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.txtPhoneUse.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhoneUse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.txtPhoneUse.Location = new System.Drawing.Point(129, 349);
            this.txtPhoneUse.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtPhoneUse.Name = "txtPhoneUse";
            this.txtPhoneUse.Size = new System.Drawing.Size(73, 27);
            this.txtPhoneUse.TabIndex = 68;
            this.txtPhoneUse.Text = "0.00";
            this.txtPhoneUse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPhoneUse
            // 
            this.lblPhoneUse.AutoSize = true;
            this.lblPhoneUse.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPhoneUse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.lblPhoneUse.Location = new System.Drawing.Point(21, 355);
            this.lblPhoneUse.Name = "lblPhoneUse";
            this.lblPhoneUse.Size = new System.Drawing.Size(88, 19);
            this.lblPhoneUse.TabIndex = 67;
            this.lblPhoneUse.Text = "Phone Use:";
            // 
            // PaymentEditor
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(525, 670);
            this.Controls.Add(this.txtPhoneUse);
            this.Controls.Add(this.lblPhoneUse);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.txtTotalAmountPaid);
            this.Controls.Add(this.lblAmountPaid);
            this.Controls.Add(this.txtTaxAmount);
            this.Controls.Add(this.lblTaxAmount);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTaxRate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAmountCharged);
            this.Controls.Add(this.lblAmountCharged);
            this.Controls.Add(this.txtTotalNights);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpLastDateOccupied);
            this.Controls.Add(this.lblLastDateOccupied);
            this.Controls.Add(this.dtpFirstDateOccupied);
            this.Controls.Add(this.lblRoomOccupiedFrom);
            this.Controls.Add(this.txtReceiptNumber);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.txtEmployeeNumber);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtAccountDetails);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpPaymentDate);
            this.Controls.Add(this.lblPaymentDate);
            this.Controls.Add(this.lblReceiptNumber);
            this.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaymentEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ceil Inn - Payment Editor";
            this.Load += new System.EventHandler(this.PaymentEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtAccountNumber;
        public System.Windows.Forms.TextBox txtEmployeeNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.TextBox txtAccountDetails;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.Label lblReceiptNumber;
        private System.Windows.Forms.Label lblRoomOccupiedFrom;
        private System.Windows.Forms.Label lblLastDateOccupied;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAmountCharged;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.Label lblTaxAmount;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblPhoneUse;
        public System.Windows.Forms.TextBox txtReceiptNumber;
        public System.Windows.Forms.TextBox txtPhoneUse;
        public System.Windows.Forms.DateTimePicker dtpFirstDateOccupied;
        public System.Windows.Forms.DateTimePicker dtpLastDateOccupied;
        public System.Windows.Forms.TextBox txtTotalNights;
        public System.Windows.Forms.TextBox txtAmountCharged;
        public System.Windows.Forms.TextBox txtTaxRate;
        public System.Windows.Forms.TextBox txtTotalAmountPaid;
        public System.Windows.Forms.TextBox txtTaxAmount;
        public System.Windows.Forms.TextBox txtSubTotal;

    }
}
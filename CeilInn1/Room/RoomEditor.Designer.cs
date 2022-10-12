﻿namespace CeilInn1
{
    partial class RoomEditor
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
            this.cbxBedTypes = new System.Windows.Forms.ComboBox();
            this.cbxRoomTypes = new System.Windows.Forms.ComboBox();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOccupancyStatus = new System.Windows.Forms.Label();
            this.cbxOccupanciesStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbxBedTypes
            // 
            this.cbxBedTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBedTypes.FormattingEnabled = true;
            this.cbxBedTypes.Items.AddRange(new object[] {
            "King",
            "Queen",
            "Double",
            "Other"});
            this.cbxBedTypes.Location = new System.Drawing.Point(132, 80);
            this.cbxBedTypes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxBedTypes.Name = "cbxBedTypes";
            this.cbxBedTypes.Size = new System.Drawing.Size(219, 24);
            this.cbxBedTypes.TabIndex = 5;
            // 
            // cbxRoomTypes
            // 
            this.cbxRoomTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoomTypes.FormattingEnabled = true;
            this.cbxRoomTypes.Items.AddRange(new object[] {
            "Bedroom",
            "Conference Room",
            "Other"});
            this.cbxRoomTypes.Location = new System.Drawing.Point(132, 47);
            this.cbxRoomTypes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxRoomTypes.Name = "cbxRoomTypes";
            this.cbxRoomTypes.Size = new System.Drawing.Size(171, 24);
            this.cbxRoomTypes.TabIndex = 3;
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(132, 15);
            this.txtRoomNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(65, 22);
            this.txtRoomNumber.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(252, 192);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(132, 192);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(132, 113);
            this.txtRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(99, 22);
            this.txtRate.TabIndex = 7;
            this.txtRate.Text = "0.00";
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bed Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Room Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Number:";
            // 
            // lblOccupancyStatus
            // 
            this.lblOccupancyStatus.AutoSize = true;
            this.lblOccupancyStatus.Location = new System.Drawing.Point(21, 149);
            this.lblOccupancyStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOccupancyStatus.Name = "lblOccupancyStatus";
            this.lblOccupancyStatus.Size = new System.Drawing.Size(47, 16);
            this.lblOccupancyStatus.TabIndex = 8;
            this.lblOccupancyStatus.Text = "Status:";
            // 
            // cbxOccupanciesStatus
            // 
            this.cbxOccupanciesStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOccupanciesStatus.FormattingEnabled = true;
            this.cbxOccupanciesStatus.Items.AddRange(new object[] {
            "Other",
            "Available",
            "Occupied"});
            this.cbxOccupanciesStatus.Location = new System.Drawing.Point(132, 145);
            this.cbxOccupanciesStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxOccupanciesStatus.Name = "cbxOccupanciesStatus";
            this.cbxOccupanciesStatus.Size = new System.Drawing.Size(219, 24);
            this.cbxOccupanciesStatus.TabIndex = 9;
            // 
            // RoomEditor
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(376, 239);
            this.Controls.Add(this.cbxOccupanciesStatus);
            this.Controls.Add(this.lblOccupancyStatus);
            this.Controls.Add(this.cbxBedTypes);
            this.Controls.Add(this.cbxRoomTypes);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RoomEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ceil Inn - Room Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cbxBedTypes;
        public System.Windows.Forms.ComboBox cbxRoomTypes;
        public System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOccupancyStatus;
        public System.Windows.Forms.ComboBox cbxOccupanciesStatus;
    }
}
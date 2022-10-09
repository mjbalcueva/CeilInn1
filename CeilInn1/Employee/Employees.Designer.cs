﻿namespace CeilInn1
{
    partial class Employees
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNewEmployee = new System.Windows.Forms.Button();
            this.lvwEmployees = new System.Windows.Forms.ListView();
            this.colEmployeeNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(313, 147);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.Location = new System.Drawing.Point(189, 147);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(118, 23);
            this.btnNewEmployee.TabIndex = 7;
            this.btnNewEmployee.Text = "New Employee...";
            this.btnNewEmployee.UseVisualStyleBackColor = true;
            this.btnNewEmployee.Click += new System.EventHandler(this.BtnNewEmployee_Click);
            // 
            // lvwEmployees
            // 
            this.lvwEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEmployeeNumber,
            this.colFirstName,
            this.colLastName,
            this.colTitle});
            this.lvwEmployees.FullRowSelect = true;
            this.lvwEmployees.GridLines = true;
            this.lvwEmployees.Location = new System.Drawing.Point(12, 10);
            this.lvwEmployees.Name = "lvwEmployees";
            this.lvwEmployees.Size = new System.Drawing.Size(376, 123);
            this.lvwEmployees.TabIndex = 6;
            this.lvwEmployees.UseCompatibleStateImageBehavior = false;
            this.lvwEmployees.View = System.Windows.Forms.View.Details;
            // 
            // colEmployeeNumber
            // 
            this.colEmployeeNumber.Text = "Employee #";
            this.colEmployeeNumber.Width = 70;
            // 
            // colFirstName
            // 
            this.colFirstName.Text = "First Name";
            this.colFirstName.Width = 80;
            // 
            // colLastName
            // 
            this.colLastName.Text = "Last Name";
            this.colLastName.Width = 80;
            // 
            // colTitle
            // 
            this.colTitle.Text = "Title";
            this.colTitle.Width = 120;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 181);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNewEmployee);
            this.Controls.Add(this.lvwEmployees);
            this.MaximizeBox = false;
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ceil Inn - Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNewEmployee;
        private System.Windows.Forms.ListView lvwEmployees;
        private System.Windows.Forms.ColumnHeader colEmployeeNumber;
        private System.Windows.Forms.ColumnHeader colFirstName;
        private System.Windows.Forms.ColumnHeader colLastName;
        private System.Windows.Forms.ColumnHeader colTitle;
    }
}
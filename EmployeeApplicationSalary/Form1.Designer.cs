namespace EmployeeApplicationSalary
{
    partial class frmComputeSalary
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFirstName = new TextBox();
            txtDepartment = new TextBox();
            txtLastName = new TextBox();
            txtJobTitle = new TextBox();
            txtRatePerHour = new TextBox();
            txtTotalHoursWorked = new TextBox();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblBasicSalary = new Label();
            btnComputeSalary = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(10, 32);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(214, 23);
            txtFirstName.TabIndex = 0;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(10, 78);
            txtDepartment.Margin = new Padding(3, 2, 3, 2);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(214, 23);
            txtDepartment.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(229, 32);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(214, 23);
            txtLastName.TabIndex = 2;
            // 
            // txtJobTitle
            // 
            txtJobTitle.Location = new Point(229, 78);
            txtJobTitle.Margin = new Padding(3, 2, 3, 2);
            txtJobTitle.Name = "txtJobTitle";
            txtJobTitle.Size = new Size(214, 23);
            txtJobTitle.TabIndex = 3;
            // 
            // txtRatePerHour
            // 
            txtRatePerHour.Location = new Point(10, 172);
            txtRatePerHour.Margin = new Padding(3, 2, 3, 2);
            txtRatePerHour.Name = "txtRatePerHour";
            txtRatePerHour.Size = new Size(214, 23);
            txtRatePerHour.TabIndex = 4;
            // 
            // txtTotalHoursWorked
            // 
            txtTotalHoursWorked.Location = new Point(228, 172);
            txtTotalHoursWorked.Margin = new Padding(3, 2, 3, 2);
            txtTotalHoursWorked.Name = "txtTotalHoursWorked";
            txtTotalHoursWorked.Size = new Size(214, 23);
            txtTotalHoursWorked.TabIndex = 5;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(112, 231);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(102, 15);
            lblFirstName.TabIndex = 6;
            lblFirstName.Text = "<first name here>";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(112, 254);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(100, 15);
            lblLastName.TabIndex = 7;
            lblLastName.Text = "<last name here>";
            // 
            // lblBasicSalary
            // 
            lblBasicSalary.AutoSize = true;
            lblBasicSalary.Location = new Point(112, 275);
            lblBasicSalary.Name = "lblBasicSalary";
            lblBasicSalary.Size = new Size(34, 15);
            lblBasicSalary.TabIndex = 8;
            lblBasicSalary.Text = "00.00";
            // 
            // btnComputeSalary
            // 
            btnComputeSalary.Location = new Point(156, 196);
            btnComputeSalary.Margin = new Padding(3, 2, 3, 2);
            btnComputeSalary.Name = "btnComputeSalary";
            btnComputeSalary.Size = new Size(143, 22);
            btnComputeSalary.TabIndex = 9;
            btnComputeSalary.Text = "Compute Salary";
            btnComputeSalary.UseVisualStyleBackColor = true;
            btnComputeSalary.Click += btnComputeSalary_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 14);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 10;
            label1.Text = "First name *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 14);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 11;
            label2.Text = "Last name *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 61);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 12;
            label3.Text = "Department *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(229, 61);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 13;
            label4.Text = "Job title *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 154);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 14;
            label5.Text = "Rate per hour *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(229, 154);
            label6.Name = "label6";
            label6.Size = new Size(115, 15);
            label6.TabIndex = 15;
            label6.Text = "Total hours worked *";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 231);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 16;
            label7.Text = "First name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 254);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 17;
            label8.Text = "Last name:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 275);
            label9.Name = "label9";
            label9.Size = new Size(71, 15);
            label9.TabIndex = 18;
            label9.Text = "Basic Salary:";
            // 
            // frmComputeSalary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 300);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnComputeSalary);
            Controls.Add(lblBasicSalary);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(txtTotalHoursWorked);
            Controls.Add(txtRatePerHour);
            Controls.Add(txtJobTitle);
            Controls.Add(txtLastName);
            Controls.Add(txtDepartment);
            Controls.Add(txtFirstName);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmComputeSalary";
            Text = "Employee Salary Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtDepartment;
        private TextBox txtLastName;
        private TextBox txtJobTitle;
        private TextBox txtRatePerHour;
        private TextBox txtTotalHoursWorked;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblBasicSalary;
        private Button btnComputeSalary;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}

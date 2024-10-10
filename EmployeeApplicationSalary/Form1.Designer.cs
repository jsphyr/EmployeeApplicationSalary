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
            txtFirstName.Location = new Point(12, 42);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(244, 27);
            txtFirstName.TabIndex = 0;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(12, 104);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(244, 27);
            txtDepartment.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(262, 42);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(244, 27);
            txtLastName.TabIndex = 2;
            // 
            // txtJobTitle
            // 
            txtJobTitle.Location = new Point(262, 104);
            txtJobTitle.Name = "txtJobTitle";
            txtJobTitle.Size = new Size(244, 27);
            txtJobTitle.TabIndex = 3;
            // 
            // txtRatePerHour
            // 
            txtRatePerHour.Location = new Point(12, 229);
            txtRatePerHour.Name = "txtRatePerHour";
            txtRatePerHour.Size = new Size(244, 27);
            txtRatePerHour.TabIndex = 4;
            // 
            // txtTotalHoursWorked
            // 
            txtTotalHoursWorked.Location = new Point(260, 229);
            txtTotalHoursWorked.Name = "txtTotalHoursWorked";
            txtTotalHoursWorked.Size = new Size(244, 27);
            txtTotalHoursWorked.TabIndex = 5;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(128, 308);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(128, 20);
            lblFirstName.TabIndex = 6;
            lblFirstName.Text = "<first name here>";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(128, 338);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(126, 20);
            lblLastName.TabIndex = 7;
            lblLastName.Text = "<last name here>";
            // 
            // lblBasicSalary
            // 
            lblBasicSalary.AutoSize = true;
            lblBasicSalary.Location = new Point(128, 367);
            lblBasicSalary.Name = "lblBasicSalary";
            lblBasicSalary.Size = new Size(44, 20);
            lblBasicSalary.TabIndex = 8;
            lblBasicSalary.Text = "00.00";
            // 
            // btnComputeSalary
            // 
            btnComputeSalary.Location = new Point(178, 262);
            btnComputeSalary.Name = "btnComputeSalary";
            btnComputeSalary.Size = new Size(163, 29);
            btnComputeSalary.TabIndex = 9;
            btnComputeSalary.Text = "Compute Salary";
            btnComputeSalary.UseVisualStyleBackColor = true;
            btnComputeSalary.Click += btnComputeSalary_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 10;
            label1.Text = "First name *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(262, 19);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 11;
            label2.Text = "Last name *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 81);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 12;
            label3.Text = "Department *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(262, 81);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 13;
            label4.Text = "Job title *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 206);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 14;
            label5.Text = "Rate per hour *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(262, 206);
            label6.Name = "label6";
            label6.Size = new Size(145, 20);
            label6.TabIndex = 15;
            label6.Text = "Total hours worked *";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 308);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 16;
            label7.Text = "First name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 338);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 17;
            label8.Text = "Last name:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 367);
            label9.Name = "label9";
            label9.Size = new Size(90, 20);
            label9.TabIndex = 18;
            label9.Text = "Basic Salary:";
            // 
            // frmComputeSalary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 400);
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

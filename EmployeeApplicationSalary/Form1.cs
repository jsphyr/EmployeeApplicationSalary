using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EmployeeApplicationSalary
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void btnComputeSalary_Click(object sender, EventArgs e)
        {
                string pattern = @"^[a-zA-Z\s]+$"; 
                try
                {
                    if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                        string.IsNullOrWhiteSpace(txtLastName.Text) ||
                        string.IsNullOrWhiteSpace(txtDepartment.Text) ||
                        string.IsNullOrWhiteSpace(txtJobTitle.Text) ||
                        string.IsNullOrWhiteSpace(txtRatePerHour.Text) ||
                        string.IsNullOrWhiteSpace(txtTotalHoursWorked.Text))
                    {
                        throw new Exception("Input fields cannot be empty!");
                    }

                    if (!Regex.IsMatch(txtFirstName.Text, pattern) ||
                        !Regex.IsMatch(txtLastName.Text, pattern) ||
                        !Regex.IsMatch(txtDepartment.Text, pattern) ||
                        !Regex.IsMatch(txtJobTitle.Text, pattern))
                    {
                        throw new Exception("Input fields can only contain letters.");
                    }

                    if (!double.TryParse(txtRatePerHour.Text, out double ratePerHour))
                    {
                        throw new FormatException("Rate per hour must be a valid number.");
                    }

                    if (!int.TryParse(txtTotalHoursWorked.Text, out int totalHoursWorked))
                    {
                        throw new FormatException("Total hours worked must be a valid number.");
                    }

                    PartTimeEmployee employee = new PartTimeEmployee(
                        txtFirstName.Text.Trim(),
                        txtLastName.Text.Trim(),
                        txtDepartment.Text.Trim(),
                        txtJobTitle.Text.Trim(),
                        ratePerHour,
                        totalHoursWorked
                    );

                    lblBasicSalary.Text = $"{employee.GetBasicSalary():C}"; 
                    lblFirstName.Text = $"{employee.GetFirstName()}";
                    lblLastName.Text = $"{employee.GetLastName()}";
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
    }

    interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Department { get; set; }
        string JobTitle { get; set; }
        double BasicSalary { get; set; }
        void getSalary();
    }

    class PartTimeEmployee : IEmployee
    {
        private string firstName;
        private string lastName;
        private string department;
        private string jobTitle;
        private double basicSalary;

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public string Department
        {
            get => department;
            set => department = value;
        }

        public string JobTitle
        {
            get => jobTitle;
            set => jobTitle = value;
        }

        public double BasicSalary
        {
            get => basicSalary;
            set => basicSalary = value;
        }

        public double RatePerHour { get; set; }
        public int TotalHoursWorked { get; set; }

        public PartTimeEmployee(string firstName, string lastName, string department, string jobTitle, double ratePerHour, int totalHoursWorked)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            JobTitle = jobTitle;
            RatePerHour = ratePerHour;
            TotalHoursWorked = totalHoursWorked;
            getSalary(); 
        }

        public void getSalary()
        {
            BasicSalary = RatePerHour * TotalHoursWorked;
        }

        public string GetFirstName() => FirstName;
        public string GetLastName() => LastName;
        public string GetDepartment() => Department;
        public string GetJobTitle() => JobTitle;
        public double GetBasicSalary() => BasicSalary;
    }
}
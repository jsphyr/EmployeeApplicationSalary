using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace EmployeeApplicationSalary
{
    public partial class frmComputeSalary : Form
    {
    public frmComputeSalary()
    {
        InitializeComponent();
    }
    interface IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public double BasicSalary { get; set; }
        public void computeSalary();

    }
    class PartTimeEmployee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public double BasicSalary { get; set; }
        public double RatePerHour { get; set; }
        public int TotalHoursWorked { get; set; }
        public void computeSalary()
        {
            BasicSalary = RatePerHour * TotalHoursWorked;
        }
    }
        private void btnComputeSalary_Click(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-Z\s]+$";
            try
            {
                if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) || string.IsNullOrWhiteSpace(txtDepartment.Text) || string.IsNullOrWhiteSpace(txtJobTitle.Text) || string.IsNullOrWhiteSpace(txtRatePerHour.Text) || string.IsNullOrWhiteSpace(txtTotalHoursWorked.Text))
                {
                    throw new Exception("Input fields cannot be empty!");
                }

                if(!Regex.IsMatch(txtFirstName.Text , pattern) || !Regex.IsMatch(txtLastName.Text , pattern) || !Regex.IsMatch(txtDepartment.Text, pattern) || !Regex.IsMatch(txtJobTitle.Text, pattern))
                {
                    throw new Exception("Input fields can only contain letters.");
                }

                    PartTimeEmployee employee = new PartTimeEmployee
                {
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    Department = txtDepartment.Text,
                    JobTitle = txtJobTitle.Text,
                    TotalHoursWorked = Convert.ToInt32(txtTotalHoursWorked.Text),
                    RatePerHour = Convert.ToDouble(txtRatePerHour.Text)
                };
                employee.computeSalary();
                lblBasicSalary.Text = employee.BasicSalary.ToString();
                lblFirstName.Text = employee.FirstName.ToString();
                lblLastName.Text = employee.LastName.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a numeric value.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
} 


    


       



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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public double BasicSalary { get; set; }
        public void computeSalary();

    }
    class PartTimeEmployee : IEmployee
    {
        private string first_name { get; set; }
        private string last_name { get; set; }
        private string department { get; set; }
        private string job_title { get; set; }
        private double basic_salary { get; set; }
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

    


       



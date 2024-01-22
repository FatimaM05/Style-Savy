using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPProject
{
    public partial class Form8 : Form
    {
        private Employee_Repository EmpRep;
        private List<Employee> Employees;
        public Form8(Employee_Repository EmpRep)
        {
          
            InitializeComponent();
            this.EmpRep = EmpRep ?? throw new ArgumentNullException(nameof(EmpRep), "Employee Repository is not initialized");
            Employees = new List<Employee>();

            LoadEmployees();
        }
        public void LoadEmployees()
        {
            if (EmpRep != null)
            {
                Employees = EmpRep.GetAllEmployees();
                if (addgrid != null)
                {
                   addgrid.DataSource = Employees;
                }
                else
                {
                    MessageBox.Show("Error: DatagridviewEmployees is not initialized");
                }
            }
            else
            {
                MessageBox.Show("Error: Employee Repository is not initialized");
            }
        }
        private void ClearInputFeilds()
        {
            txtIDbox.Clear();
            txtNameBox.Clear();
            txtEmailBox.Clear();
            txtCNICbox.Clear();
            txtPhoneNumberBox.Clear();
            txtsalarybox.Clear();
        }
        private void txtAddEmployee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDbox.Text) || string.IsNullOrWhiteSpace(txtNameBox.Text) ||
               string.IsNullOrWhiteSpace(txtPhoneNumberBox.Text) || string.IsNullOrWhiteSpace(txtCNICbox.Text) ||
               string.IsNullOrWhiteSpace(txtEmailBox.Text) || string.IsNullOrWhiteSpace(txtsalarybox.Text))
            {
                MessageBox.Show("Fill in the all fields,");
                return;
            }
            //Input
            string EmployeeName = txtNameBox.Text;
            string email = txtEmailBox.Text;
            string Cnic = txtCNICbox.Text;
            long salary;
            long PhoneNumber;
            int EmployeeId;
            if (!int.TryParse(txtIDbox.Text, out EmployeeId) || !long.TryParse(txtPhoneNumberBox.Text, out PhoneNumber) 
                || !long.TryParse(txtsalarybox.Text, out salary))
            {
                MessageBox.Show("Invalid Input. Please Enter valid Number.");
                return;
            }
            //Adding employee
            Employee newemployye = new Employee
            { 
                Employee_ID = EmployeeId,
                Name = EmployeeName,
                Email = email,
                Contact_Number = PhoneNumber,
                Employee_Salary = salary,
                CNIC = Cnic,
            };
            EmpRep.AddEmployeeToDatabase(newemployye);
            LoadEmployees();
            ClearInputFeilds();
            MessageBox.Show("Employee has been Added successfully");
        }
    }
}

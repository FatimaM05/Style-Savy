using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOPProject
{
    public partial class Form9 : Form
    {
        private Employee_Repository EmpRep;
        private List<Employee> Employees;
        public Form9(Employee_Repository EmpRep)
        {
            InitializeComponent();
            this.EmpRep = EmpRep ?? throw new ArgumentNullException(nameof(EmpRep), "Employee Repository is not initialized");
            Employees = new List<Employee>();
            LoadEmployees();
            updategrid.CellClick += UpdateGrid_Cellclick;
        }
        private Employee SEmployee;
        private void UpdateGrid_Cellclick(object sender, DataGridViewCellEventArgs e)
        {
            SEmployee = (Employee)updategrid.SelectedRows[0].DataBoundItem;
            txtIDbox.Text = SEmployee.Employee_ID.ToString();
            txtNameBox.Text = SEmployee.Name;
            txtEmailBox.Text = SEmployee.Email;
            txtCNICbox.Text = SEmployee.CNIC.ToString();
            txtsalarybox.Text = SEmployee.Employee_Salary.ToString();
            txtPhoneNumberBox.Text = SEmployee.Contact_Number.ToString();
            txtupdateEmployee.Enabled = true;
        }
        public void LoadEmployees()
        {
            if (EmpRep != null)
            {
                Employees = EmpRep.GetAllEmployees();
                if (updategrid != null)
                {
                    updategrid.DataSource = Employees;
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

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void txtupdateEmployee_Click(object sender, EventArgs e)
        {
            if (updategrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select the Employee to update.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtIDbox.Text) || string.IsNullOrWhiteSpace(txtNameBox.Text) ||
               string.IsNullOrWhiteSpace(txtPhoneNumberBox.Text) || string.IsNullOrWhiteSpace(txtCNICbox.Text) ||
               string.IsNullOrWhiteSpace(txtEmailBox.Text) || string.IsNullOrWhiteSpace(txtsalarybox.Text))
            {
                MessageBox.Show("Please fill in all fields");
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
            Employee selectedEmployee = (Employee)updategrid.SelectedRows[0].DataBoundItem;
            EmpRep.DeleteEmployee(selectedEmployee);
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
            MessageBox.Show("Employee has been updated successfully");
        }
    }
}

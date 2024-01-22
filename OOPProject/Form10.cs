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
    public partial class Form10 : Form
    {
        private Employee_Repository EmpRep;
        private List<Employee> Employees;
        public Form10(Employee_Repository EmpRep)
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
                if (EmployeesGrid != null)
                {
                    EmployeesGrid.DataSource = Employees;
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
        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void EmployeesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpRep.GetAllEmployees();
        }
        //Searching customer through ID
        private void SearchEmployeeByID(List<Employee> Employees, int ID)
        {
            bool foundemployee = false;
            foreach (Employee emp in Employees)
            {
                if (emp.Employee_ID == ID)
                {
                    EmpRep.DisplayEmployee(emp);
                    loadanEmployee(emp);
                    foundemployee = true;
                    break;
                }
            }
            if (!foundemployee)
            {
                MessageBox.Show("No Employee Found.");
            }
        }
        //Creating new Datatable to show the selcted id result
        private DataTable DataTable = new DataTable();
        private void loadanEmployee(Employee employee)
        {
            DataTable.Clear();
            if (DataTable.Columns.Count == 0)
            {
                DataTable.Columns.Add("ID");
                DataTable.Columns.Add("Name");
                DataTable.Columns.Add("CNIC");
                DataTable.Columns.Add("Email");
                DataTable.Columns.Add("Contact");
                DataTable.Columns.Add("Salary");
            }

            DataTable.Rows.Add
            (employee.Employee_ID,
             employee.Name,
             employee.CNIC,
             employee.Email,
             employee.Contact_Number,
             employee.Employee_Salary);

            EmployeesGrid.DataSource = DataTable;
        }
        //Button click by search
        private void SearchButton_Click(object sender, EventArgs e)
        {
          

        }

        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Fill in the field");
                return;
            }
            int EmployeeId;
            if (!int.TryParse(txtID.Text, out EmployeeId))
            {
                MessageBox.Show("Invalid Input. Please Enter valid Number.");
                return;
            }
            SearchEmployeeByID(Employees, EmployeeId);

        }
    }

}


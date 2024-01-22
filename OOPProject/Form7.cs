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
    public partial class Form7 : Form
    {
        private Employee_Repository EmpRep;
        private List<Employee> Employees;
        public Form7(Employee_Repository EmpRep)
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
                if (DeleteGrid != null)
                {
                    DeleteGrid.DataSource = Employees;
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

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void DeleteEmployee_Click(object sender, EventArgs e)
        {
            if (DeleteGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee to delete");
                return;
            }
            DialogResult reult = MessageBox.Show("are you sure you want to delete the employee?", "Confirmation", MessageBoxButtons.YesNo);
            if (reult == DialogResult.Yes)
            {
                Employee selectedEmployee = (Employee)DeleteGrid.SelectedRows[0].DataBoundItem;
                EmpRep.DeleteEmployee(selectedEmployee);
                LoadEmployees();
                MessageBox.Show("The Employee has been deleted succesfully");
            }
        }

        private void LoadEmployee(Employee emp)
        {
            DeleteGrid.DataSource = new List<Employee>() { emp };
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Fill the feild");
                return;

            }
            int EmployeeID;
            if(!int.TryParse(txtID.Text, out EmployeeID))
            {
                MessageBox.Show("Invalid input! Please enter the valid Number./n Thanks!");
                return;
            }
            Employee employee = Employees.FirstOrDefault(e => e.Employee_ID == EmployeeID);
            if (employee != null)
            {
                EmpRep.DisplayEmployee(employee);
                LoadEmployee(employee);
                
            }
            else
            {
                MessageBox.Show("Employee Not found");
            }
            txtID.Clear();
        }
    }
}

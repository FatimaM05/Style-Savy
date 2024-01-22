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
    public partial class Form3 : Form
    {
        private Customer_Repository CusRep;
        private List<Customer> Customers;
        public Form3(Customer_Repository CusRep)
        {
            InitializeComponent();
            this.CusRep = CusRep ?? throw new ArgumentNullException(nameof(CusRep), "Customer Repository cannot be null");

            Customers = new List<Customer>();
            LoadCustomers();
        }
        private void LoadCustomers()
        {
            //Check if Repository is empty
            if (CusRep != null)
            {
                Customers = CusRep.GetAllCustomers();
                if (CustomersGrid != null)
                {
                    CustomersGrid.DataSource = Customers;
                }
                else
                {
                    MessageBox.Show("Error: dataGridViewCustomers is not initialized");
                }
            }
            else
                MessageBox.Show("Error: Customers Reposiroty is not initialized");
        }
        //Displaying all customers
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CusRep.GetAllCustomers();
        }
        //Searching customer through ID
        private void SeachCustomerByID(List<Customer> Customers, int ID)
        {
            bool foundcustomer = false;
            foreach (Customer customer in Customers)
            {
                if (customer.Customer_Id == ID)
                {
                    CusRep.DisplayCustomer(customer);
                    loadAcustomer(customer);
                    foundcustomer = true;
                    break;
                }
            }
            if (!foundcustomer)
            {
                MessageBox.Show("No Customer Found.");
            }
        }
        //Creating new Datatable to show the selcted id result
        private DataTable DataTable = new DataTable();
        private void loadAcustomer(Customer customer)
        {
            DataTable.Clear();
            if (DataTable.Columns.Count == 0)
            {
                DataTable.Columns.Add("ID");
                DataTable.Columns.Add("Name");
                DataTable.Columns.Add("CNIC");
                DataTable.Columns.Add("Email");
                DataTable.Columns.Add("Contact");
                DataTable.Columns.Add("Membership");
            }

            DataTable.Rows.Add
            (customer.Customer_Id,
             customer.Name,
             customer.CNIC,
             customer.Email,
             customer.Contact_Number,
             customer.Membership);

            CustomersGrid.DataSource = DataTable;
        }
        //Button click by search
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Fill in the field");
                return;
            }
            int CustomerId;
            if (!int.TryParse(txtID.Text, out CustomerId))
            {
                MessageBox.Show("Invalid Input. Please Enter valid Number.");
                return;
            }
            SeachCustomerByID(Customers, CustomerId);

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

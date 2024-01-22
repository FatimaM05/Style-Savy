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
    public partial class Form5 : Form
    {
        private Customer_Repository CusRep;
        private List<Customer> Customers;
        public Form5(Customer_Repository CusRep)
        {
            InitializeComponent();
            this.CusRep = CusRep ?? throw new ArgumentNullException(nameof(CusRep), "Customer Repository cannot be null");

            Customers = new List<Customer>();
            LoadCustomers();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void txtUpdate_Click(object sender, EventArgs e)
        {
            //Confirming the selection
            if (Deletegrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select a Customer To Delete");
                return;
            }
            //Confirming Deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete the customer?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Customer selectedCustomer = (Customer)Deletegrid.SelectedRows[0].DataBoundItem;
                CusRep.DeleteCustomer(selectedCustomer);
                LoadCustomers();
                MessageBox.Show("Customer has been deleted succeessfully");
            }
        }

        private void LoadCustomers()
        {
            //Check if Repository is empty
            if (CusRep != null)
            {
                Customers = CusRep.GetAllCustomers();
                if (Deletegrid != null)
                {
                    Deletegrid.DataSource = Customers;
                }
                else
                {
                    MessageBox.Show("Error: dataGridViewCustomers is not initialized");
                }
            }
            else
                MessageBox.Show("Error: Customers Reposiroty is not initialized");
        }
        //=============================================================//
        //Delete selcted id result
        private DataTable DataTable = new DataTable();
        private void loadAcustomer(Customer customer)
        {
            Deletegrid.DataSource = new List<Customer>() { customer };
        }
 
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click_1(object sender, EventArgs e)
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
            //Loading the searched customer
        
            Customer c1 = Customers.FirstOrDefault(c => c.Customer_Id == CustomerId);
            if( c1 != null)
            {
                CusRep.DisplayCustomer(c1);
                loadAcustomer(c1);
            }
            else
            {
                MessageBox.Show("Customer not found");
            }
            txtID.Clear();
        }
    }
}

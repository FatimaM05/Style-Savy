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
    public partial class Form6 : Form
    {
        private Customer_Repository CusRep;
        private List<Customer> Customers;
        public Form6(Customer_Repository CusRep)
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
                if (dataGridViewCustomers != null)
                {
                    dataGridViewCustomers.DataSource = Customers;
                }
                else
                {
                    MessageBox.Show("Error: dataGridViewCustomers is not initialized");
                }
            }
            else
                MessageBox.Show("Error: Customers Reposiroty is not initialized");
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
        private void ClearInputFeilds()
        {
            txtIDbox.Clear();
            txtNameBox.Clear();
            txtEmailBox.Clear();
            txtCNICbox.Clear();
            txtPhoneNumberBox.Clear();
            
        }

        private void txtAddCustomer_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDbox.Text) || string.IsNullOrWhiteSpace(txtNameBox.Text) ||
               string.IsNullOrWhiteSpace(txtPhoneNumberBox.Text) || string.IsNullOrWhiteSpace(txtCNICbox.Text) || string.IsNullOrWhiteSpace(txtEmailBox.Text))
            {
                MessageBox.Show("Fill in the all fields,");
                return;
            }

            //Parse Input
            string CustomerName = txtNameBox.Text;
            string email = txtEmailBox.Text;
            string Cnic = txtCNICbox.Text;
            string membership = comboBox1.Text;
            long PhoneNumber;
            int CustomerId;

            if (!int.TryParse(txtIDbox.Text, out CustomerId) || !long.TryParse(txtPhoneNumberBox.Text, out PhoneNumber))
            {
                MessageBox.Show("Invalid Input. Please Enter valid Number.");
                return;
            }

            //Adding A new customer
            Customer newCustomer = new Customer
            {
                Customer_Id = CustomerId,
                Name = CustomerName,
                Email = email,
                CNIC = Cnic,
                Contact_Number = PhoneNumber,
                Membership = membership
            };
            // Addding customer to customer Repository
            CusRep.AddCustomerToDatabase(newCustomer);

            //Loading Customers
            LoadCustomers();
            ClearInputFeilds();
            MessageBox.Show("Customer has been Added successfully");
        }
    }
}

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
    public partial class Form4 : Form
    {
        private Customer_Repository CusRep;
        private List<Customer> Customers;
        public Form4(Customer_Repository CusRep)
        {
            InitializeComponent();
            this.CusRep = CusRep ?? throw new ArgumentNullException(nameof(CusRep), "Customer Repository cannot be null");

            Customers = new List<Customer>();
            LoadCustomers();
            updategrid.CellClick += UpdateGrid_Cellclick;
        }
        private Customer sCustomer;
        private void UpdateGrid_Cellclick(object sender, DataGridViewCellEventArgs e)
        {
            sCustomer = (Customer)updategrid.SelectedRows[0].DataBoundItem;
            txtIDbox.Text = sCustomer.Customer_Id.ToString();
            txtNameBox.Text = sCustomer.Name;
            txtEmailBox.Text = sCustomer.Email;
            txtCNICbox.Text = sCustomer.CNIC.ToString();
            comboBox1.Text = sCustomer.Membership;
            txtPhoneNumberBox.Text = sCustomer.Contact_Number.ToString();
            txtUpdate.Enabled = true;
        }
        private void LoadCustomers()
        {
            //Check if Repository is empty
            if (CusRep != null)
            {
                Customers = CusRep.GetAllCustomers();
                if (updategrid != null)
                {
                    updategrid.DataSource = Customers;
                }
                else
                {
                    MessageBox.Show("Error: dataGridViewCustomers is not initialized");
                }
            }
            else
                MessageBox.Show("Error: Customers Reposiroty is not initialized");
        }
        //Updating customer
        private void Form4_Load(object sender, EventArgs e)
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

        private void txtUpdate_Click(object sender, EventArgs e)
        {
            if (updategrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select the customer to update.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNameBox.Text) || string.IsNullOrWhiteSpace(txtIDbox.Text)
            || string.IsNullOrWhiteSpace(txtPhoneNumberBox.Text) || string.IsNullOrWhiteSpace(txtCNICbox.Text)
            || string.IsNullOrWhiteSpace(txtEmailBox.Text))
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }
            //input
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
            //delete
            Customer selectedCustomer = (Customer)updategrid.SelectedRows[0].DataBoundItem;
            CusRep.DeleteCustomer(selectedCustomer);
            //add
            Customer UpdatedCustomer = new Customer
            {
                Customer_Id = CustomerId,
                Name = CustomerName,
                Email = email,
                CNIC = Cnic,
                Contact_Number = PhoneNumber,
                Membership = membership
            };
            //Adding new account to repository
            CusRep.AddCustomer(UpdatedCustomer);
            CusRep.AddCustomerToDatabase(UpdatedCustomer);
            LoadCustomers();
            ClearInputFeilds();
            MessageBox.Show("Updated!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

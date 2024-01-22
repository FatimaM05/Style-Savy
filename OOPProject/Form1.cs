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
    public partial class Form1 : Form
    {
        private Customer_Repository CusRep;
        private List<Customer> Customers;
        public Form1(Customer_Repository CusRep)
        {
            InitializeComponent();
            this.CusRep = CusRep ?? throw new ArgumentNullException(nameof(CusRep), "Customer Repository cannot be null");

            Customers = new List<Customer>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //=================================Add Button=================================//
        private void txtAddCustomer_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(CusRep);
            form6.Show();
        }
        //=================================Delete Button=================================//
        private void txtdeletecustomer_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(CusRep);
            form5.Show();
        }
        //=================================UPdate Button=================================//
        private void txtUpdate_Click(object sender, EventArgs e)
        {

            Form4 form4 = new Form4(CusRep);
            form4.Show();
        }
        //=================================View Button=================================//
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(CusRep);
            form3.Show();
        }
    }
}

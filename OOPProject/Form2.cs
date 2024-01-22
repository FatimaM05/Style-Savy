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
    public partial class Form2 : Form
    {
        private Employee_Repository EmpRep;
        private List<Employee> Employees;
        public Form2(Employee_Repository EmpRep)
        {
            InitializeComponent();
            this.EmpRep = EmpRep ?? throw new ArgumentNullException(nameof(EmpRep), "Employee Repository is not initialized");
            Employees = new List<Employee>();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        //=================================Delete Button=================================//
        private void button1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(EmpRep);
            form7.Show();
        }
        //=================================Add Button=================================//
        private void button2_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(EmpRep);
            form8.Show();
        }
        //=================================Update Button=================================//
        private void button3_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9(EmpRep);
            form9.Show();

        }
        //=================================View Button=================================//
        private void button4_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10(EmpRep);
            form10.Show();
        }
    }
}

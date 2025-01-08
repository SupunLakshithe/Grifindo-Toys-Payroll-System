using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Toys
{
    public partial class Salary_interface : Form
    {
        public Salary_interface()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Salary_interface_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.getdtable("SELECT * FROM salary");

            DataTable dt = new DataTable();
            dt = db.getdtable("SELECT id,name FROM employe ");
            cmbx_select_emp.DataSource = dt;
            cmbx_select_emp.DisplayMember = "name";
            cmbx_select_emp.ValueMember = "id";
            cmbx_select_emp.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = cmbx_select_emp.SelectedIndex;
            Salary salary = new Salary(id);
            salary.intialize();
            MessageBox.Show(salary.report());

        }

        private void cmbx_select_emp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbx_select_emp.SelectedIndex == -1)
            {
                button1.Enabled=false;
                chk_b_paid.Enabled=false;
            }
            else
            {
                button1.Enabled = true;
                chk_b_paid.Enabled=true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_Home admin_Home = new Admin_Home();
            this.Close();
            admin_Home.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Admin_Home admin_Home = new Admin_Home();
            admin_Home.log_out_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = cmbx_select_emp.SelectedIndex;
            Salary salary = new Salary(id);
            salary.intialize();
            salary.generate();
            Salary_interface_Load(sender, e);
        }

        private void chk_b_paid_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

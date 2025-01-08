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

namespace Grifindo_Toys
{
    public partial class Admin_employee : Form
    {
        public Admin_employee()
        {
            InitializeComponent();
        }

        private void Admin_employee_Load(object sender, EventArgs e)
        {
            dataGridView1.Focus();
            dataGridView1.DataSource = db.getdtable("SELECT * FROM Employe");

            DataTable dt = new DataTable();
            dt = db.getdtable("SELECT * FROM job_type ");
            cmb_emp_job.DataSource=dt;
            cmb_emp_job.DisplayMember = "type";
            cmb_emp_job.ValueMember = "id";
            cmb_emp_job.SelectedIndex = -1;

            DataTable dtbr = new DataTable();
            dtbr = db.getdtable("SELECT * FROM branch ");
            comboBox2.DataSource = dtbr;
            comboBox2.DisplayMember = "city";
            comboBox2.ValueMember = "id";
            comboBox2.SelectedIndex = -1;
            clean();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = cmb_emp_job.SelectedIndex;
            object salary = db.getvalue("SELECT M_salary FROM job_type WHERE id = '" + id + "'");
            object ot_rate = db.getvalue("SELECT ot_rate FROM job_type WHERE id = '" + id + "'");
            Employee employee = new Employee(txt_emp_name.Text,Convert.ToDecimal(salary),Convert.ToDecimal(ot_rate), Convert.ToDecimal(txt_emp_alwnce.Text), txt_emp_nic.Text, txt_emp_phone.Text,comboBox2.SelectedIndex,cmb_emp_job.SelectedIndex);
            employee.add_emp_details();
            Admin_employee_Load(sender, e);
        }

        private void clean()
        {
            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.TextBox)
                {
                    System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)control;
                    // Do something with the text box
                    textBox.Clear();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int id = cmb_emp_job.SelectedIndex ;
            object salary = db.getvalue("SELECT M_salary FROM job_type WHERE id = '" + id + "'");
            object ot_rate = db.getvalue("SELECT ot_rate FROM job_type WHERE id = '" + id + "'");
            Employee employee = new Employee(int.Parse( txt_emp_id.Text), txt_emp_name.Text, Convert.ToDecimal(salary), Convert.ToDecimal(ot_rate), Convert.ToDecimal(txt_emp_alwnce.Text), txt_emp_nic.Text, txt_emp_phone.Text, comboBox2.SelectedIndex, cmb_emp_job.SelectedIndex);
            employee.update();
            Admin_employee_Load(sender, e);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    txt_emp_alwnce.Text = dataGridView1.Rows[e.RowIndex].Cells["alwnce"].FormattedValue.ToString();
                    txt_emp_id.Text = dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                    txt_emp_name.Text = dataGridView1.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
                    txt_emp_nic.Text = dataGridView1.Rows[e.RowIndex].Cells["nic"].FormattedValue.ToString();
                    txt_emp_phone.Text = dataGridView1.Rows[e.RowIndex].Cells["phone_no"].FormattedValue.ToString();
                    cmb_emp_job.SelectedIndex = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["job_type"].FormattedValue);
                    comboBox2.SelectedIndex = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["br_id"].FormattedValue);
                }
            }
            catch
            {
                MessageBox.Show("Not Valid , please select a valid row");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee.employe_delete(int.Parse(txt_emp_id.Text));
            Admin_employee_Load(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Admin_Home admin_Home = new Admin_Home();
            admin_Home.log_out_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_Home admin_Home = new Admin_Home();
            this.Close();
            admin_Home.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.getdtable("SELECT * FROM employe WHERE name LIKE '%" + Txt_search.Text + "%'");
        }
    }
}

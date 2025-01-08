using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Grifindo_Toys
{
    public partial class jobs : Form
    {
        public jobs()
        {
            InitializeComponent();
        }
        int id;
        private void jobs_Load(object sender, EventArgs e)
        {

            dataGridView.DataSource = db.getdtable("SELECT * FROM job_type");
            txt_salary.Clear();
            txt_over_time_rate.Clear();
            txt_job.Clear();

        }

 

        private void button1_Click(object sender, EventArgs e)
        {
            string job_type = txt_job.Text;
            string salary = txt_salary.Text;
            string over_time_rate = txt_over_time_rate.Text;
            int grp = Convert.ToInt32(comboBox.Text);
            db.access("INSERT INTO job_type (type,M_salary,ot_rate,user_grp) VALUES ('" + job_type + "','" + salary + "','" + over_time_rate + "','" + grp + "')");
            jobs_Load(sender, e);
        }

        private void clear()
        {
            string job_type = txt_job.Text;
            string salary = txt_salary.Text;
            string over_time_rate = txt_over_time_rate.Text;
            int grp = Convert.ToInt32(comboBox.Text);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView.CurrentRow.Selected = true;
                    txt_job.Text = dataGridView.Rows[e.RowIndex].Cells["type"].FormattedValue.ToString();
                    txt_salary.Text = dataGridView.Rows[e.RowIndex].Cells["M_salary"].FormattedValue.ToString();
                    txt_over_time_rate.Text = dataGridView.Rows[e.RowIndex].Cells["ot_rate"].FormattedValue.ToString();
                    comboBox.Text = dataGridView.Rows[e.RowIndex].Cells["user_grp"].FormattedValue.ToString();
                    id = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Not Valid , please select a valid row");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string job_type = txt_job.Text;
            string salary = txt_salary.Text;
            string over_time_rate = txt_over_time_rate.Text;
            int grp = Convert.ToInt32(comboBox.Text);
            db.access("UPDATE job_type SET type= '" + job_type + "', M_salary = '" + salary + "', ot_rate= '" + txt_over_time_rate.Text + "', user_grp = '" + grp + "' WHERE id = '" + id + "'");
            jobs_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin_Home admin_Home = new Admin_Home();
            admin_Home.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Admin_Home admin_Home = new Admin_Home();
            admin_Home.log_out_Click(sender, e);
        }
    }
}

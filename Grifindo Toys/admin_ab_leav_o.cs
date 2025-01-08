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
    public partial class admin_ab_leav_o : Form
    {
        public admin_ab_leav_o()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime currentDate = DateTime.Now.Date;
                int cycle = Convert.ToInt32(db.getvalue("SELECT id FROM cycle WHERE '" + currentDate.ToString() + "' BETWEEN startd AND endd"));
                db.access("INSERT INTO abcent (emp_id,date,cycle_id) VALUES ('" + cmb_ab.SelectedIndex + "','" + date_t_ab.Value + "','" + cycle + "')");

            }
            catch
            {
                MessageBox.Show("Already Added");
            }

       }

        private void admin_ab_leav_o_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.getdtable("SELECT id,name FROM employe ");

            cmb_ot.DataSource = dt;
            cmb_ot.DisplayMember = "name";
            cmb_ot.ValueMember = "id";
            cmb_ot.SelectedIndex = -1;

            cmb_ab.DataSource = dt;
            cmb_ab.DisplayMember = "name";
            cmb_ab.ValueMember = "id";
            cmb_ab.SelectedIndex = -1;

            cmb_lv.DataSource = dt;
            cmb_lv.DisplayMember = "name";
            cmb_lv.ValueMember = "id";
            cmb_lv.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                db.access("INSERT INTO leave (emp_id,date) VALUES ('" + cmb_lv.SelectedIndex + "','" + dt_lv.Value + "')");
            }
            catch
            {
                MessageBox.Show("Already Added");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime currentDate = DateTime.Now.Date;
                int cycle = Convert.ToInt32(db.getvalue("SELECT id FROM cycle WHERE '" + currentDate.ToString() + "' BETWEEN startd AND endd"));
                db.access("INSERT INTO overtime (emp_id,date,count,cycle_id) VALUES ('" + cmb_ot.SelectedIndex + "','" + dt_ot.Value + "','" + txt_hr.Text + "','" + cycle + "')");
            }
            catch
            {
                MessageBox.Show("Already Added");
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
    }
}

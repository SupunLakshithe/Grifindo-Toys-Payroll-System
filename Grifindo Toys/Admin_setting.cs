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
    public partial class Admin_setting : Form
    {
        public Admin_setting()
        {
            InitializeComponent();
        }

        private void Admin_setting_Load(object sender, EventArgs e)
        {
            int cylce = Convert.ToInt32(db.getvalue("SELECT MAX(id) FROM cycle"));
            progressBar1.Value = 20;
            lbl_cycle.Text = cylce.ToString();
            progressBar1.Value = 40;
            date_t_start.Value = Convert.ToDateTime(db.getvalue("SELECT endd FROM cycle WHERE id = '" + cylce + "'"));
            progressBar1.Value = 50;
            txt_duration.Text = Convert.ToString(db.getvalue("SELECT duration FROM cycle"));

            txt_max_leaves.Text = db.getvalue("SELECT count_leaves FROM setting").ToString();
            txt_max_abcent.Text = db.getvalue("SELECT max_abcent FROM setting").ToString();
            txt_tax_rate.Text = db.getvalue("SELECT tax_rate FROM setting").ToString();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            Admin_Home admin_Home = new Admin_Home();
            this.Close();
            admin_Home.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Admin_Home admin_Home = Application.OpenForms.OfType<Admin_Home>().FirstOrDefault();
            admin_Home.log_out_Click(sender, e);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (date_t_end.Value < date_t_start.Value)
            {
                date_t_end.Value = date_t_start.Value.AddDays(int.Parse(txt_duration.Text));
                MessageBox.Show("Duration aded");
                return;
            }
            else { }
            DateTime dateTimedb = Convert.ToDateTime(db.getvalue("SELECT TOP 1 endd FROM cycle"));
            if (dateTimedb > date_t_start.Value)
            {
                MessageBox.Show("Error");
            }
            else
            {
               db.access("INSERT INTO cycle (startd,endd,duration) VALUES ('" + date_t_start.Value + "','" + date_t_end.Value + "','" + txt_duration.Text + "')");
            }
            Admin_setting_Load(sender, e);
        }

        private void chk_b_enble_duration_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_b_enble_duration.Checked)
            {
                txt_duration.Enabled = true;
            }
            else
            {
                txt_duration.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.access("UPDATE setting SET count_leaves = '" + txt_max_leaves.Text + "', max_abcent = '" + txt_max_abcent.Text + "', tax_rate = '" + txt_tax_rate.Text + "' WHERE (1=1)");
        }

        private void lbl_cycle_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Admin_Home : Form
    {
        public Admin_Home()
        {
            InitializeComponent();
        }

        private void Admin_Home_Load(object sender, EventArgs e)
        {
            lbl_cycle.Text = db.getvalue("SELECT MAX(id) FROM cycle").ToString();             
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_setting admin_Setting = new Admin_setting();
            admin_Setting.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Salary_interface salary = new Salary_interface();
            salary.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_employee admin_Employee = new Admin_employee();
            admin_Employee.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            jobs jobs = new jobs();
            jobs.Show();
        }

        public void log_out_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].GetType() != typeof(Login))
                {
                    Application.OpenForms[i].Close();
                }
            }

            Login login = new Login();
            login.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            admin_ab_leav_o admin_Ab_Leav_O = new admin_ab_leav_o();
            admin_Ab_Leav_O.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
    }
}

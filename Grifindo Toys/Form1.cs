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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string user_name = textBox1.Text;
            string password = textBox2.Text;

            try
            {
               string value = db.getvalue("SELECT password FROM credentials WHERE password = '" + password + "'")? .ToString()?? "hjhj";
                if (password == value)
                {
                    Admin_Home admin_Home = new Admin_Home();
                    this.Hide();
                    admin_Home.Show();
                }
                else { throw new Exception(); }
            }
            catch
            {
                MessageBox.Show("Username or Password invalid");
            }

            
        }
    }
}

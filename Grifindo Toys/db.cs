using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Data;

namespace Grifindo_Toys
{
    internal class db
    {
        private static string con_str = "Data Source=LAPTOP-LENOVOI5\\SQLEXPRESS;Initial Catalog=\"Grifindo Toys\";Integrated Security=True";

        public db(string constr)
        {
            con_str = constr;
        }


        public static bool access(string query)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(con_str);
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Adding DaTa to DataBase\n \n \n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static object getvalue(string query)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(con_str);
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                object value = sqlCommand.ExecuteScalar();
                sqlConnection.Close();
                return value;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error get object from DataBase\n \n \n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

        }

        public static DataTable getdtable(string query)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(con_str);
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                da.Fill(dt);
                sqlConnection.Close();
                da.Dispose();
                return dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error get object from DataBase\n \n \n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
    }
}
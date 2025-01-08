using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Grifindo_Toys
{
    internal class Employee
    {
        public int Id;
        public string name;
        public decimal M_salary;
        public decimal ot_rate;
        public decimal alwnce;
        public string nic;
        public string phone_no;
        public int br_id;
        public int job_type;
        private static string tablename = "Employe"; // teble name at the database

        public Employee (string name, decimal M_salary, decimal ot_rate, decimal alwnce , string nic, string phone_no , int br_id , int job_type)
        {
            //get employee basic details (for insert)
            this.name = name;
            this.M_salary = M_salary;
            this.ot_rate = ot_rate;
            this.alwnce = alwnce;
            this.nic = nic;
            this.phone_no = phone_no;
            this.br_id = br_id;
            this.job_type = job_type;
        }

        public Employee(int id, string name, decimal M_salary, decimal ot_rate, decimal alwnce, string nic, string phone_no , int br_id ,int job_type )
        {
            //get employee basic details with the id (for update)
            this.Id = id;
            this.name = name;
            this.M_salary = M_salary;
            this.ot_rate = ot_rate;
            this.alwnce = alwnce;
            this.nic = nic;
            this.phone_no = phone_no;
            this.br_id=br_id;
            this.job_type = job_type;
        }

        public bool  add_emp_details()
        {
            //add the employee to the database 
            return db.access("INSERT INTO " + tablename + " (name,M_salary,ot_rate,alwnce,nic,phone_no,br_id,job_type) VALUES ('" + this.name + "','" + this.M_salary + "','" + this.ot_rate + "','" + this.alwnce + "','" + this.nic + "','" + this.phone_no + "','"+this.br_id+"','"+this.job_type+"' )");
        }

        public static bool employe_delete(int id)
        {
            //delete a employee from database
            return db.access(" DELETE FROM " + tablename + " WHERE id = '" + id + "'");
        }

        public bool update()
        {
            //update data
            return db.access(" UPDATE " + tablename + " SET name = '" + this.name + "', M_salary = '" + this.M_salary + "', ot_rate = '" + this.ot_rate + "', alwnce = '" + this.alwnce + "', nic = '" + this.nic + "', phone_no = '" + this.phone_no + "', br_id = '"+this.br_id+"', job_type = '"+this.job_type+"'  WHERE id = '" + this.Id + "'"); 
        }


    }
}

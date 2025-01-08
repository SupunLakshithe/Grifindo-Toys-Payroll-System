using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grifindo_Toys
{
    internal class Salary
    {

        public decimal emp_mo_sal ;
        public decimal emp_ot_rate;
        public decimal emp_alwnce;
        public decimal tax_rate;
        public int duration;
        public int emp_absent;
        public int emp_ot_h;
        public int emp_id;
        public string emp_name;

        public Salary (int id)
        {
            this.emp_id = id;
        }

        public void intialize()
        {
            this.emp_mo_sal = Convert.ToDecimal(db.getvalue("SELECT M_salary FROM Employe WHERE id = '" + this.emp_id + "'"));
            this.emp_ot_rate = Convert.ToDecimal(db.getvalue("SELECT ot_rate FROM Employe WHERE id = '" + this.emp_id + "'"));
            this.emp_alwnce = Convert.ToDecimal(db.getvalue("SELECT alwnce FROM Employe WHERE id = '" + this.emp_id + "'"));
            this.emp_name = Convert.ToString(db.getvalue("SELECT name FROM Employe WHERE id = '" + this.emp_id + "'"));
            this.tax_rate = Convert.ToDecimal(db.getvalue("SELECT tax_rate FROM setting WHERE 1 = 1"));
            this.duration = Convert.ToInt32(db.getvalue("SELECT duration FROM cycle WHERE 1 = 1"));

            //check if employee have no pay absents
            int max_absent = Convert.ToInt32(db.getvalue("SELECT max_abcent FROM setting  WHERE 1= 1"));
            int absent = Convert.ToInt32(db.getvalue("SELECT COUNT (id) FROM abcent WHERE emp_id = '" + this.emp_id + "'"));
            if (absent - max_absent > 0)
            {
                this.emp_absent = absent - max_absent;
            }
            else { this.emp_absent = 0; }

            //get total over time hours
            try
            {
                this.emp_ot_h = Convert.ToInt32(db.getvalue("SELECT SUM (count) FROM overtime WHERE emp_id = '" + this.emp_id + "'"));
            }
            catch { this.emp_ot_h = 0; }
        }

        //calculate nopay
        public decimal novalue( )
        {
            return emp_absent * (emp_mo_sal / duration);
        }

        //calculate base pay value
        public decimal basevalue()
        {
            return emp_mo_sal + emp_alwnce + (emp_ot_h * emp_ot_rate); 
        }

        //calculate gross pay value
        public decimal gross_payvalue()
        {
            return this.basevalue() - (this.novalue() + this.basevalue() * this.tax_rate/100);
        }

        public string report()
        {
            string rep = "This Report is For [" + emp_id + "] " + emp_name + "\n \n \n " +
                " NO PAY value is :  " + novalue() + " £ \n \n \n" +
                " BASE PAY value is :  " + basevalue() + " £ \n\n\n" +
                " GROSS PAY value is :  " + gross_payvalue() + " £";
            return rep;
        }

        public bool generate()
        {
            int oldcycle = Convert.ToInt32(db.access("SELECT MAX(id) FROM cycle")) ;

            return db.access("INSERT INTO salary (emp_id,cycle_id,base_pay,no_pay,gross_pay,payed,emp_name) VALUES ('" + this.emp_id + "','" + oldcycle + "','" + basevalue() + "','" + novalue() + "','" + gross_payvalue() + "','0','"+this.emp_name+"')");

        }
    }
}

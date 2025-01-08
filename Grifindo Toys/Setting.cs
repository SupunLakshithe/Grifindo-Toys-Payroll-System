using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Toys
{
    internal class Setting
    {
        public DateTime strtd;
        public DateTime endd;
        public int duration;  
        public int count_leaves; // leave count max
        public int max_abcent;  //abcent count max
        public decimal tax_rate; //tax

        private string tablename = "setting";
        public  Setting ( DateTime startD , int durat , int leave , int maxab , decimal tax_rate)
        {
            this.strtd = startD.Date ;
            this.duration=durat;
            this.count_leaves = leave;
            this.max_abcent = maxab;
            this.tax_rate = tax_rate;
            //generate end date
            this.endd = this.strtd.AddDays (duration);

        }

        public Setting(DateTime startD, DateTime end , int leave , int maxab , Decimal tax_rate )
        {
            this.strtd = startD.Date;
            this.endd = end.Date;
            this.count_leaves = leave;
            this.max_abcent=maxab;
            this.tax_rate=tax_rate;

            //generate duration
            this.endd = this.strtd.AddDays(duration);

        }

        // update data in table
        public bool update()
        {
            db.access("INSERT INTO stting_his (startd,endd,duration) VALUES ('" + this.strtd + "','" + this.endd + "','" + this.duration + "')");
            return db.access("UPDATE " + tablename + "SET strtd = '" + this.strtd + "', endd = '" + this.endd + "', duration = '" + this.duration + "', count_leaves = '" + this.count_leaves + "' max_abcent = '" + this.max_abcent + "' tax_rate = '" + this.tax_rate + "' WHERE id = 1 ");
            //add exiting data to history table
        }


    }
}

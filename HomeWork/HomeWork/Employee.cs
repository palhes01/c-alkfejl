using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Employee :Worker
    {
        public int InternalID { get; set; }
        public string Post { get; set; }
        public int OverTime { get; set; }
        public static double OverTimePay { get; set; }

        public Employee(int internalID,string post,int overTime,string name,string address,long basicSalary)
                        :base(name,address,basicSalary)
        {
            InternalID = internalID;
            Post = post;
            OverTime = overTime;
        }
 

        public override double Payment()
        {
            return base.Payment()+(Convert.ToDouble(OverTime)*OverTimePay);

        }

        public override string ToString()
        {
       
            return string.Format("Alkalmazott: {0} {1} ", Post, Name);
        }


        
    }
}

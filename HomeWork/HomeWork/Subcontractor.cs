using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Subcontractor :Worker,IComparable
    {

        public DateTime EndOfContract { get; set; }
        public String Project  { get; set; }
        public double SuccesFee { get; set; }
        


        public Subcontractor(DateTime endOfContract, string project,double succesfee,string name, string address, long basicSalary)
            :base(name, address, basicSalary)
        {
            EndOfContract = endOfContract;
            Project = project;
            SuccesFee = succesfee;
        }

        public override double Payment()
        {
            return BasicSalary + SuccesFee;
        }

        public override string ToString()
        {
           return string.Format("Alkvállalkozó:{0} {1} ", EndOfContract.ToShortDateString(), Name);
        }


       

        public int CompareTo(object obj)
        {
            Subcontractor other = obj as Subcontractor;
            if (other!= null)
            {


                if (EndOfContract < other.EndOfContract) return -1;
                if (EndOfContract > other.EndOfContract) return 1;
                return 0;
            }
            return -1;
        }
        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class outsourced : Worker,IComparable
    {
        public String Job { get; set; }
        public String  Employer { get; set; }
        public double ShiftBonus { get; set; }

        public outsourced(int id,string post, string job, string employer, double shiftbonus, string name, string address, long basicSalary) 
            :base(name, address, basicSalary)
        {
            Job = job;
            Employer = employer;
            ShiftBonus = shiftbonus;
        }

        public override double Payment()
        {
            return base.Payment() + ShiftBonus;

        }
        public override string ToString()
        {
            return string.Format("Kiszervezett:{0,5} {1} ", Employer, Name);
        }

        public int CompareTo(object obj)
        {
            outsourced other = obj as outsourced;
            if (other != null)
            {


                if (Employer.Equals(other.Employer)) return -1;
                    return 0;
            }
            return -1;
        }
    }
}

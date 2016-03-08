using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Worker
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string  Taxnumber { get; set; }
        public  long BasicSalary { get; set; }



        public Worker(string name,string address, long basicSalary)
        {
            Name = name;
            Address = address;
            BasicSalary = basicSalary;        
        }

        public virtual double Payment()
        {
            return BasicSalary;

        }

        public override string ToString()
        {
         return string.Format(" Dolgozó:{0, 10} ({1})", Name,Address);
        }



    }
}

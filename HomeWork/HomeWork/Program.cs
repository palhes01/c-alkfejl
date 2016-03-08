using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {


          
            //outsourced(int id,string post, string job, string employer, double shiftbonus, string name, string address, long basicSalary)
            List<outsourced> outsourcedlist = new List<outsourced>();

            outsourcedlist.Add(new outsourced(10,"sale","IT","ITS",21,"Béla Gábor","9700 Pécs Boszi",2500));
            outsourcedlist.Add(new outsourced(10, "sale", "IT", "ITS", 21, "Béla Gábor", "9700 Pécs Boszi", 2500));
            outsourcedlist.Add(new outsourced(10, "sale", "IT", "ITS", 21, "Béla Gábor", "9700 Pécs Boszi", 2500));
            outsourcedlist.Add(new outsourced(10, "sale", "IT", "ITS", 21, "Béla Gábor", "9700 Pécs Boszi", 2500));
            outsourcedlist.Add(new outsourced(10, "sale", "IT", "ITS", 21, "Béla Gábor", "9700 Pécs Boszi", 2500));

            Console.WriteLine();
            foreach (outsourced outsoured in outsourcedlist)
            {
                
              Console.WriteLine(outsoured);
            }

            // public Subcontractor(DateTime endOfContract, string project,double succesfee,string name, string address, long basicSalary)
            List<Subcontractor> subcontractor = new List<Subcontractor>();
            subcontractor.Add(new Subcontractor (new DateTime(1921,2,1),"PRog",15,"Kiss","dsfsadf",1546));
            subcontractor.Add(new Subcontractor(new DateTime(1920, 2, 1), "PRog", 15, "Ass", "dsfsadf", 1546));
            subcontractor.Add(new Subcontractor(new DateTime(1520, 2, 1), "PRog", 15, "pss", "dsfsadf", 1546));

            foreach (Subcontractor subcontrac in subcontractor)
            {

                Console.WriteLine(subcontrac);
            }
            Console.WriteLine();
            subcontractor.Sort();
            foreach (Subcontractor subcontrac in subcontractor)
            {
                Console.WriteLine(subcontrac);
            }



            List<Worker> workers = new List<Worker>();

            workers.AddRange(subcontractor);
            workers.AddRange(outsourcedlist);
            Console.WriteLine();
            Console.WriteLine("Dolgozok:");

            foreach (Worker worker in workers)
            {
                Console.WriteLine(worker);
            }



            Console.ReadKey();


        }
    }
}

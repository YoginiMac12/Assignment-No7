using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_No7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Course c1 = new Course();
            //c1.Id = Convert.ToInt32(Console.ReadLine());
            //c1.Name = Console.ReadLine();
            //c1.Fees = Convert.ToSingle(Console.ReadLine());

            //Console.WriteLine($"{c1.Id} {c1.Name} {c1.Fees}");



            //Course c2 = new Course { Id = 2, Name = "Java", Fees = 50000f };
            //Console.WriteLine($"{c2.Id} {c2.Name} {c2.Fees}");


            Department d1 = new Department();
            d1.Deptid = Convert.ToInt32(Console.ReadLine());
            d1.Deptname = Console.ReadLine();
            d1.Location = Console.ReadLine();

            Console.WriteLine($"{d1.Deptid} {d1.Deptname} {d1.Location}");


            Department d2 = new Department { Deptid = 2, Deptname = "IT Department", Location = "Mumbai" };
            Console.WriteLine($"{d2.Deptid} {d2.Deptname} {d2.Location}");
        }
    }
}


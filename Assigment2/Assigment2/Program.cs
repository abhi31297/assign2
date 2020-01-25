using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee EMP = new HR(101, "Abhishek", "HR", 8000, 5, DateTime.Parse("2019/09/09"));
            Console.WriteLine("salary of HR is: "+EMP.salary());

            Employee emp = new Developer(101, "Deven", "developer", 8000, 5, DateTime.Parse("2020/01/01"));
            Console.WriteLine("salary of Developer is: " + emp.salary());

        }
    }
}

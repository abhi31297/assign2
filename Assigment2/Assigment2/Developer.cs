using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Developer : Employee
    {
        public Developer(int id, string name, string designation, int salary, int experience, DateTime joindate) : base(id, name, designation, salary, experience, joindate)
        { }

        public override int salary()
        {
            return GetSal() + (GetExp() * 2000);
        }

    }
}
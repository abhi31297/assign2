using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public abstract class Employee
    {
        private int _Id;
        private string _Name;
        private string _Designation;
        private int _Salary;
        private int _Experience;
        private DateTime _Joindate;

        public Employee(int id, string name, string designation, int salary, int experience, DateTime joindate)
        {
            this._Id = id;
            this._Name = name;
            this._Designation =designation;
            this._Salary = salary;
            this._Experience = experience;
            this._Joindate = joindate;
        }

        public int GetSal()
        {
            return this._Salary;
        }

        public int GetExp()
        {
            return this._Experience;
        }

        public abstract int salary();

    }
}
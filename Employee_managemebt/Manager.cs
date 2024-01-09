using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignment
{
    internal class Manager : Employee
    {
        private string designation;
        private  decimal basic;

        public string Designation
        {
            set { 
                if(!string.IsNullOrEmpty(value)) 
                designation = value; }
            get { return designation; }
        }

        public override decimal Basic
        {
            get { return this.basic; }
            set
            {
                if (value > 5000)
                    this.basic = value;
                else
                    Console.WriteLine("sal is to less");
            }
        }

        public Manager(string Name, short Deptno, decimal Basic, string Designation) : base(Name, Deptno, Basic)
        {
            this.Designation = Designation;

           
        }

        
        public override string ToString()
        {
            return base.ToString()+"\nDESIGNATION="+designation;
        }

        public override decimal CalNetSalary()
        {
            return Basic + 1000;
        }
    }
}

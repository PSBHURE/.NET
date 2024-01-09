using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignment
{
    internal class CEO:Employee
    {
        private string company_name;
        public string Company_name
        {
            set { company_name = value; }
            get { return company_name; }
        }
        public CEO(string Name, short Deptno, decimal Basic,string Company_name) : base(Name, Deptno, Basic)
        {
            this.Company_name = Company_name;
        }

        public override decimal Basic { get => 0; set => Console.WriteLine("true"); }

        public sealed override decimal CalNetSalary()
        {
            return Basic + 3000;
        }
        public override string ToString()
        {
            return base.ToString()+"\nCompany_name="+company_name;
        }
    }
}

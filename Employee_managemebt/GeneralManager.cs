using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignment
{
    internal class GeneralManager:Manager
    {
        public string Perks { get; set; }
        public GeneralManager(string Name, short Deptno, decimal Basic, string Designation,string Perks) : base(Name, Deptno, Basic, Designation)
        {
            this.Perks = Perks;
        }
        public override decimal CalNetSalary()
        {
            return Basic+2000;
        }
        public override string ToString()
        {
            return base.ToString()+"\nPERKS="+Perks;
        }
    }
}

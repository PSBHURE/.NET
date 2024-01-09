using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignment
{
    public interface I1
    {
        public void Insert();
        public void Update();
        public void Delete();

    }
    public abstract class Employee:I1
    {
        private string name;
        private int empno;
        private static int lastempno;
        private short deptno;
        public abstract decimal Basic {  get; set; }

        public short Deptno
        {
            set
            {
                if (value > 0)
                    deptno = value;
            }
            get
            {
                return deptno;
            }
        }
        public string Name
        {
            set
            {
                if(!string.IsNullOrEmpty(value))
                    name = value;
            }
            get
            {
                return name;
            }
        }
        public int Empno
        {
            get { return empno; }
        }
        public Employee(string Name,short Deptno,decimal Basic) 
        {
            this.empno = ++lastempno;
            this.Name = Name;
            this.Deptno = Deptno;
            this.Basic = Basic;
        }

        public void Insert()
        {
            Console.WriteLine("Insert method from Employee class");
        }

        public void Update()
        {
            Console.WriteLine("Update method from Employee class");
        }

        public void Delete()
        {
            Console.WriteLine("Delete method from Employee class");
        }
        public abstract decimal CalNetSalary();
        public override string ToString()
        {
            return "\nEMPNO="+empno+"\nNAME="+name+"\nDEPTNO="+deptno+"\nBASIC="+Basic;
        }
    }
}

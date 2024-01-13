using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Handler
{
    public delegate void InvalidInput();
    internal class Employee
    {
        public event InvalidInput InvalidateBasic;
        private int basic;
        public int Basic
        {
            set
            {
                if (value > 10000)
                    this.basic = value;
                else
                    if (InvalidateBasic != null)
                    InvalidateBasic();
            }
            get { return this.basic; }

        }
        public void Display()
        {
            Console.WriteLine("Hello IACSD");
        }
    }
}

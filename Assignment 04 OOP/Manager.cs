using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_OOP
{
    internal class Manager: Employee
    {
        public override void myMethod()
        {
            base.myMethod();
            Console.WriteLine("Manager is managing");
        }
    }
}

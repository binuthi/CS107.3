using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp4.Program;

namespace ConsoleApp4
{
    internal class Class1
    {
        class Program
        {
            static void Main(string[] args)
            {
                MyClass myObject = new MyClass();

                // The following line will result in a compilation error
                // because the sayHello() method is private and inaccessible.
                myObject.sayHello();
            }
        }

    }
}

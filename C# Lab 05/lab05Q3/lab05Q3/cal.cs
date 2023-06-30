using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05Q3
{
    internal class cal
    { 
        int a;
        int b;
        int sum;
        int subtraction;
        int multiplication;
        int division;
    
        public void add()
        {
            sum = a + b;
            Console.WriteLine("sum is: " + sum);
        }
        public void sub()
        {
            subtraction = a - b;
            Console.WriteLine("subtraction is: " + subtraction);
        }
        public void multipl()
        {
            multiplication = a * b;
            Console.WriteLine("multiplication is: " + multiplication);
        }
        public void div()
        {
            subtraction = a / b;
            Console.WriteLine(" division is: " + division);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q02
{
    class calculator
    {
        int a;
        int b;
        int sum;
        int subtraction;
        int multiplication;
        int division;
        public void getdata()
        {
            Console.Write("Enter a whole number: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter a whole number: ");
            b = int.Parse(Console.ReadLine());
        }
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
        public void  multipl()
        {
            multiplication  = a * b;
            Console.WriteLine("multiplication is: " + multiplication);
        }
        public void div()
        {
            subtraction = a / b;
            Console.WriteLine(" division is: " + division);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            calculator c = new calculator();
            c.getdata();
            c.add();
            c.sub();
            c.multipl();
            c.div();
            Console.ReadLine();
        }
    }
}

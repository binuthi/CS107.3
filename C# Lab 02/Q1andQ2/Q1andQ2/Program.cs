using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1andQ2
{
    
    class cal
    {
        int a;
        int b;
        int addition;
        public void getdata()
        {
            Console.Write("Enter a whole number: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter a whole number: ");
            b = int.Parse(Console.ReadLine());
        }
        public void sum()
        {
            addition = a + b;
            Console.WriteLine("The addition is " + addition);
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            cal c = new cal();
            c.getdata();
            c.sum();
            Console.ReadLine();
        }
    }
}

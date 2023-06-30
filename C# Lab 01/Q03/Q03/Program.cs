using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q03
{
    class cal
    {
        double no1;
        double no2;
        double s;
        public void getdata()
        {
            Console.Write("Enter a numbers:  ");
            no1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a numbers:  ");
            no2 = Convert.ToDouble(Console.ReadLine());
        }
        public void sum()
        {
            s = no1 + no2;
            Console.WriteLine("The sum is " + s);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            cal cal = new cal();
            cal.getdata();
            cal.sum();
            Console.ReadLine();

        }
    }
}

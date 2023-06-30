using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string batch;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Enter your batch: ");
            batch = Console.ReadLine();

            Console.WriteLine("Hello " + name);
            Console.WriteLine("Your batch is " + batch);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06Q08
{
    internal class Program
    {
        public class Pro
        {
            public static void Main(string[] args)
            {
                Animal animal = new Animal();
                dog dog = new dog();

                animal.DisplayAnimalInfo(); 
                dog.Display();
                Console.ReadLine();
            }
        }

    }
}


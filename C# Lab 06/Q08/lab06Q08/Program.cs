using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06Q08
{
    internal class Program
    {
        public class Animal
        {
            public void DisplayAnimalInfo()
            {
                Console.WriteLine("I am an animal");
            }
        }

        public class Dog : Animal
        {
            public void DisplayDogInfo()
            {
                Console.WriteLine("I have four legs");
            }
        }

        public class Pro
        {
            public static void Main(string[] args)
            {
                Animal animal = new Animal();
                Dog dog = new Dog();

                animal.DisplayAnimalInfo(); 
                dog.DisplayDogInfo();
                Console.ReadLine();
            }
        }

    }
}


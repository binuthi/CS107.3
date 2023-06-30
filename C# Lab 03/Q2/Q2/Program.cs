using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    { 
        public class Pro
        {
            public static void Main(string[] args)
            {
                Console.Write("Enter a string: ");
                string input = Console.ReadLine();

                int vowelCount = CountVowels(input);

                Console.WriteLine("Number of vowels: " + vowelCount);
            }

            public static int CountVowels(string str)
            {
                int count = 0;

               
                string lowerCaseStr = str.ToLower();

                
                foreach (char c in lowerCaseStr)
                {
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    {
                        count++;
                    }
                }

                return count;
            }
        }

    }
}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q06
{
    internal class @class
    {
        public void array(int z)
        {
            int[] a = new int[z];
            for (int i = 0; i < a.Length; i = i + 2)
            {
                Console.WriteLine($"Enter items for the array: ");
                a[i] = int.Parse(Console.ReadLine());
                if (i + 1 < z)
                {
                    a[i + 1] = 0;
                }
                for(int j = 0; j < a.Length; j++)
                {
                    Console.Write($"{a[j]},");
                }
            }
        }
    }
}

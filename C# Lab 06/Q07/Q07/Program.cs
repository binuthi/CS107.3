using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q07
{
    internal class Program
    {
        public class ArrayOperations
        {
            public static void Main(string[] args)
            {
                Console.Write("Enter the size for the arrays: ");
                int size = Convert.ToInt32(Console.ReadLine());

                int[] array1 = new int[size];
                int[] array2 = new int[size];
                int scalarSum = 0;
                int SSum = 0;
                int scalarProduct = 0;

                // Input values into the first array
                Console.WriteLine("Enter values for the first array:");
                for (int i = 0; i < size; i++)
                {
                    Console.Write("Enter value for index " + i + ": " );
                    array1[i] = Convert.ToInt32(Console.ReadLine());
                    scalarSum = scalarSum + array1[i];
                }

                // Input values into the second array
                Console.WriteLine("Enter values for the second array:");
                for (int i = 0; i < size; i++)
                {
                    Console.Write("Enter value for index " + i + ": ");
                    array2[i] = Convert.ToInt32(Console.ReadLine());
                    SSum = SSum + array2[i];
                }
         
                // Calculate vector sum
                Console.WriteLine("Vector Sum:");
                int[] vectorSum = new int[size];
                for (int i = 0; i < size; i++)
                {
                    vectorSum[i] = array1[i] + array2[i];
                   Console.Write($"{ vectorSum[i]} ,");
                }

                // Calculate vector product
                Console.WriteLine("\nVector Product:");
                int[] vectorProduct = new int[size];
                for (int i = 0; i < size; i++)
                {
                    vectorProduct[i] = array1[i] * array2[i];
                    
                    Console.Write($"{vectorProduct[i]},");
                }

                // Calculate scalar product
               
                for (int i = 0; i < size; i++)
                {
                    scalarProduct = scalarProduct + vectorProduct[i];
                }

                // Display the results
                Console.WriteLine("\nScalar Sum of array 01: " + scalarSum);
                Console.WriteLine("Scalar sum of array 02: "+SSum);
                Console.WriteLine("Scalar Product: " + scalarProduct);
                Console.ReadLine();
            }

           
        }

    }

}


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

                // Input values into the first array
                Console.WriteLine("Enter values for the first array:");
                for (int i = 0; i < size; i++)
                {
                    Console.Write("Enter value for index " + i + ": ");
                    array1[i] = Convert.ToInt32(Console.ReadLine());
                }

                // Input values into the second array
                Console.WriteLine("Enter values for the second array:");
                for (int i = 0; i < size; i++)
                {
                    Console.Write("Enter value for index " + i + ": ");
                    array2[i] = Convert.ToInt32(Console.ReadLine());
                }

                // Calculate scalar sum
                int scalarSum = 0;
                for (int i = 0; i < size; i++)
                {
                    scalarSum += array1[i] + array2[i];
                }

                // Calculate vector sum
                int[] vectorSum = new int[size];
                for (int i = 0; i < size; i++)
                {
                    vectorSum[i] = array1[i] + array2[i];
                }

                // Calculate vector product
                int[] vectorProduct = new int[size];
                for (int i = 0; i < size; i++)
                {
                    vectorProduct[i] = array1[i] * array2[i];
                }

                // Calculate scalar product
                int scalarProduct = 0;
                for (int i = 0; i < size; i++)
                {
                    scalarProduct += array1[i] * array2[i];
                }

                // Display the results
                Console.WriteLine("Scalar Sum: " + scalarSum);
                Console.WriteLine("Vector Sum:");
                DisplayArray(vectorSum);
                Console.WriteLine("Vector Product:");
                DisplayArray(vectorProduct);
                Console.WriteLine("Scalar Product: " + scalarProduct);
            }

            public static void DisplayArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            }
        }

    }

}


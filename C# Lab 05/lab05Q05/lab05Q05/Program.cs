using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05Q05
{
    internal class Program
    {
        public class ArrayOperations
        {

            public static void Main(string[] args)
            {
                int[] array = new int[10];

                // Input values into the array
                Console.WriteLine("Enter 10 integers:");
                for (int i = 0; i < 10; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }

                // Call the method to perform operations
                PerformArrayOperations(array);
            }

            public static void PerformArrayOperations(int[] array)
            {
                // Find minimum value
                int min = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                    }
                }

                // Find maximum value
                int max = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                }

                // Calculate average value
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                double average = (double)sum / array.Length;

                // Reverse the order of values
                int[] reversedArray = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    reversedArray[i] = array[array.Length - 1 - i];
                }

                // Print the results
                Console.WriteLine("Minimum value: " + min);
                Console.WriteLine("Maximum value: " + max);
                Console.WriteLine("Average value: " + average);
                Console.WriteLine("Reversed order of values:");
                Console.ReadLine();
                for (int i = 0; i < reversedArray.Length; i++)
                {
                    Console.Write(reversedArray[i] + " ");
                }
                Console.ReadLine();
            }


        }

    }
}


    



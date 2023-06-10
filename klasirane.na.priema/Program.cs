using System;

namespace klasirane.na.priem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("All results:");

            string input = Console.ReadLine();
            string[] values = input.Split(", ");

            int[] points = new int[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                points[i] = int.Parse(values[i].Trim());
            }

            Console.WriteLine("Results before sorting:");
            PrintPoints(points);

            BubbleSortAlgorithm(points);

            Console.WriteLine("Results after sorting:");
            PrintPoints(points);
        }

        static void BubbleSortAlgorithm(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        static void PrintPoints(int[] points)
        {
            int n = points.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write(points[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
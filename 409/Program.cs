using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _409
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Стойности на А");
            int[] A = new int[n];
            FillArray(A);
            Console.WriteLine("Стойности на B");
            int[] B = new int[n];
            FillArray(B);
            Console.WriteLine("Стойности на C");
            int[] C = new int[n];
            FillArray(C);
            Console.WriteLine("Средноаритметично на елементите на масива A: {0}",+Average(A));
            Console.WriteLine("Средноаритметично на елементите на масива B: {0}", +Average(B));
            Console.WriteLine("Средноаритметично на елементите на масива C:{0}", +Average(C));
            double[] min = new double[] { Average(A), Average(B), Average(C) };
            double minaverage = min.Min();
            Console.WriteLine("Mинималната от трите средноаритм.стойности: {0}",+minaverage);

        }
        static void FillArray(int[]array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        static double Average(int[]array)
        {
            double average = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i]/7==0)
                {
                    average += array[i];
                }
            }
            return average / array.Length;
        }
        
    }
}

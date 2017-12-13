using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert hours in A:");
            int[] A = new int[n];
            Input(A);
            Console.WriteLine("Insert hours in B:");
            int[] B = new int[n];
            Input(B);
            Console.WriteLine("Insert hours in C:");
            int[] C = new int[n];
            Input(C);
            Console.WriteLine("Average for A:{0}",+Average(A));
            Console.WriteLine("Average for B:{0}",+Average(B));
            Console.WriteLine("Average for C:{0}",+Average(C));
            double averageA = Average(A);
            double averageB = Average(B);
            double averageC = Average(C);
            Console.WriteLine("Above average for A:");
            AboveAverage(A, averageA);
            Console.WriteLine("Above average for B:");
            AboveAverage(B, averageB);
            Console.WriteLine("Above average for C:");
            AboveAverage(C, averageC);

        }
        static void Input(int[]hours)
        {
            for (int i = 0; i < hours.Length; i++)
            {
                Console.WriteLine("Day {0}",i+1);
                hours[i] = int.Parse(Console.ReadLine());
            }
        }
        static double Average(int[]hours)
        {
            double average = 0;
            for (int i = 0; i < hours.Length; i++)
            {
                average += hours[i];
            }
            return average / hours.Length;
        }
        static void AboveAverage(int[]hours,double avrg)
        {
            for (int i = 0; i < hours.Length; i++)
            {
                if(hours[i]>avrg)
                {
                    Console.Write("Day {0}; ", i + 1);
                }
            }
            Console.WriteLine();
        }
    }
}

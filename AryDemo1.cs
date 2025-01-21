using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVB
{
    internal class AryDemo1
    {
        static void Main(string[] args)
        {
            int[] ary = new int[5];
            int sum = 0, avg;

            Console.WriteLine("Input 5 element: ");
            for (int i = 0; i < ary.Length; i++)
            {
                ary[i] = Int32.Parse(Console.ReadLine());
                sum += ary[i];

            }
            Console.WriteLine("Element are: ");
            for (int i = 0; i < ary.Length; i++)
            {
                Console.WriteLine(ary[i]);
            }
            avg = sum / ary.Length;
            Console.WriteLine("Avarege of array element: "+avg);

            int min,max;

            min = ary[0];

            for(int i =0; i < ary.Length; i++)
            {
                if (ary[i] < min)
                    min = ary[i];
            }
            Console.WriteLine("Minimum element of array is: "+min);
            max = ary.Length;
            for (int i = 0; i < ary.Length; i++)
            {
                if (ary[i] > max)
                    max = ary[i];
            }
            Console.WriteLine("Maximum element of array is: " + max);
            Console.WriteLine("Sum of all element: " + ary.Sum());
            Console.WriteLine("Number of element: "+ary.Count());
            Console.WriteLine("Average of element: "+ary.Average());
            Console.WriteLine("Minimum element: " + ary.Min());
            Console.WriteLine("Maximum element: "+ary.Max());
        }
    }
}

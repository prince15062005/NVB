using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVB
{
    internal class TDAry
    {
        static void Main(string[] args)
        {
            /*int[,] ary = new int[2, 2];
            ary[0,0] = 1;
            ary[0,1] = 2;
            ary[1,0] = 3;
            ary[1,1] = 4;*/
            //int[,] ary = { { 10, 11 }, { 12, 13 } };

            /*Console.WriteLine("First element: " + ary[0,0]);
            Console.WriteLine("Second element: " + ary[0,1]);
            Console.WriteLine("Third element: " + ary[1,0]);
            Console.WriteLine("Fourth element: " + ary[1,1]);*/

            int[,] ary = new int[2, 2];
            int[,] ary1 = new int[2, 2];
            int[,] ary3 = new int[2, 2];
            Console.WriteLine("Enetr element in first aryy of 2 x 2");
            for (int i = 0; i < ary.GetLength(0); i++)
            {
                for (int j = 0; j < ary.GetLength(1); j++)
                {
                    ary[i,j]=Int32.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Enetr element in Second aryy of 2 x 2");
            for (int i = 0; i < ary1.GetLength(0); i++)
            {
                for (int j = 0; j < ary1.GetLength(1); j++)
                {
                    ary1[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            
            for (int i = 0; i < ary3.GetLength(0); i++)
            {
                for (int j = 0; j < ary3.GetLength(1); j++)
                {
                    ary3[i, j] = ary[i, j] + ary1[i, j];
                }
            }
            Console.WriteLine("Sum of 2x2 array:");
            for(int i = 0;i < ary3.GetLength(0); i++)
            {
                for(int j = 0;j < ary3.GetLength(1); j++)
                {
                    Console.Write(ary3[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVB
{
    internal class AryDemo
    {
        static void Main(string[] args)
        {
            /*int[] age = new int[5];
            age[0] = 20;
            age[1] = 50;
            age[2] = 27;
            age[3] = 18;
            age[4] = 30;*/
            int[] age = { 20, 50, 27, 18, 30 };

            /*Console.WriteLine("First Person Age: " + age[0]);
            Console.WriteLine("Second Person Age: " + age[1]);
            Console.WriteLine("Third Person Age: " + age[2]);
            Console.WriteLine("Fourth Person Age: " + age[3]);
            Console.WriteLine("Fifth Person Age: " + age[4]);

            age[2] = 29;
            Console.WriteLine("Third Person Updated Age: " + age[2]);*/
            for (int i = 0; i < age.Length; i++)
            {
                Console.WriteLine(age[i]);
            }
            Console.WriteLine("Tracersal of array using ForEach");
            foreach (int i in age)
            {
                Console.WriteLine(i);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVB
{
    internal class UserInputDemo
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Name is: "+name);
            int a;
            Console.WriteLine("Enter value of a: ");
            a = Int32.Parse(Console.ReadLine());

            int b;
            Console.WriteLine("Enter value of b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Value of A: " + a);
            Console.WriteLine("value of B: "+ b);
            Console.WriteLine("Sum of to a and b is: "+(a+b));

            double d1;
            Console.WriteLine("Enter value of d1: ");
            d1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Value of d1: " + d1);

            double d2;
            Console.WriteLine("Enter value of d2: ");
            d2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Value of d2: " + d2);
        }
    }
}

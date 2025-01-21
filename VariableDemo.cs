using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVB
{
    internal class VariableDemo
    {
        static void Main(string[] args)
        {
            int no;
            float fno = 3.5f;
            double dno = 14.555;
            char a = 'a';
            string name = "Rahul";
            String str = "Object of str class";
            no = 15;

            Console.WriteLine("Integer number: " + no);
            Console.WriteLine("Float Number: "+fno);
            Console.WriteLine("Double value: "+dno);
            Console.WriteLine("Character is " + a);
            Console.WriteLine("string datatype value "+name);
            Console.WriteLine("String Object value: "+str);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVB
{
    public class a
    {
        int x1;
        int x2;
        public a(int x1, int x2)
        {
            Console.WriteLine("Base class constructor");
            this.x1 = x1;
            this.x2 = x2;
        }

        public void showA()
        {
            Console.WriteLine("x1: " + x1);
            Console.WriteLine("x2: " + x2);
        }
    }

    public class b : a
    {
        int y1;
        int y2;
        public b(int x1, int x2, int y1, int y2) : base(x1, x2)
        {
            Console.WriteLine("Derived class Constructor");
            this.y1 = y1;
            this.y2 = y2;
        }
        public void showB() 
        { 
            Console.WriteLine("y1: " + y1);
            Console.WriteLine("y2: " + y2);
        }
    }

    internal class DemoInh
    {
        static void Main(string[] args)
        {
            b ob = new b(10,20,60,40);
            ob.showA();
            ob.showB();
        }
    }
}

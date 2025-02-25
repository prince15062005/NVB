using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVB
{
    public class A
    {
        protected int x;
        protected void setA()
        {
            x = 10;
        }
    }

    public class B : A
    {
        int y;

        public void setB()
        {
            //x = 10;
            setA();
            y = 20;
        }

        public void showValue()
        {
            Console.WriteLine("X: " + x);
            Console.WriteLine("Y: " + y);
        }
    }
    internal class DemoInher
    {
        static void Main(string[] args)
        {
            B ob = new B();
            //ob.setA();
            ob.setB();
            ob.showValue();
            //ob.x = 50;
            //ob.y = 40;
            //ob.showValue();
        }
    }
}

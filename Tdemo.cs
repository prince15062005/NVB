using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVB
{
    public class Time
    {
        int hour;
        int minute;
        int second;
        string t;
        public Time()
        {
            Console.WriteLine("Enter hour: ");
            hour = Int32.Parse(Console.ReadLine());

            Console.WriteLine("enter Minute: ");
            minute = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second: ");
            second = Int32.Parse(Console.ReadLine());
        }

        public void increment()
        {
            t = hour + ":" + minute + ":" + second;
            Console.WriteLine("Acuale time is: " + t);

            second = second + 1;
            if(second >= 60)
            {
                second = 00;
                minute = minute + 1;
                if (minute >= 60)
                {
                    minute = 00;
                    hour = hour + 1;
                    if(hour >= 12)
                    {
                        hour = 0;
                        hour = hour + 1;
                    }
                }
            }
            t = hour + ":" + minute + ":" + second;

            Console.WriteLine("Updated time is: " + t);
        }
    }
    internal class Tdemo
    {
        static void Main(string[] args)
        {
            Time t = new Time();
            t.increment();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVB
{
    public class Book1
    {
        double price;
        int pages;
        string colour;

        public void getData()
        {
            Console.WriteLine("Enter Book Price:");
            price = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Book Pages");
            pages = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter Book Colour");
            colour = Console.ReadLine();

        }
        public void showData()
        {
            Console.WriteLine("Book Price is: " + price);
            Console.WriteLine("Book Pages are: " + pages);
            Console.WriteLine("Book Colour is: " + colour);
        }
    }
    class DemoClass1
    {
        public static void Main(string[] args)
        {
            Book1 b1 = new Book1();
            Console.WriteLine("Enter Book 1 details");
            b1.getData();
            
            Book1 b2 = new Book1();
            Console.WriteLine("Enter Book 2 details");
            b2.getData();

            Console.WriteLine("Book 1 details");
                b1.showData();

            Console.WriteLine("Book 2 details");
            b2.showData();
        }
    }
}

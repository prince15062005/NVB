using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVB
{
    public class Book
    {
        double price;
        int pages;
        string colour;

        public void getData(double price, int pages, string colour)
        {
            this.price = price;
            this.pages = pages;
            this.colour = colour;

        }
        public void showData()
        {
            Console.WriteLine("Book Price is: " + price);
            Console.WriteLine("Book Pages are: " + pages);
            Console.WriteLine("Book Colour is: " + colour);
        }
    }
    class DemoClass
    {
        public static void Main(string[] args)
        {
            Book b1 = new Book();
            Console.WriteLine("Book 1 details");
            b1.getData(70.00,200,"Red");
            b1.showData();
            Book b2 = new Book();
            Console.WriteLine("Book 2 details");
            b2.getData(300.00, 100, "Green");
            b2.showData();
        }
    }
}
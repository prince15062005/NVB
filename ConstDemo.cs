using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVB
{
    public class Product
    {
        int pid;
        string pname;
        double price;
        static string brand = "DELL";

        public Product()
        {
            Console.WriteLine("Enetr product id: ");
            pid = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter product name: ");
            pname = Console.ReadLine();
            Console.WriteLine("Enter Product price: ");
            price = Double.Parse(Console.ReadLine());
        }
        public void showData()
        {
            Console.WriteLine("Product ID is: " + pid);
            Console.WriteLine("Product Name is: " + pname);
            Console.WriteLine("Product Price is: " + price);
            Console.WriteLine("Product Brand is: " + brand);
        }
    }
    internal class ConstDemo
    {
        static void Main(string[] args)
        {
            /*Product[] p = new Product[5];
            
            for (int i = 0; i < p.Length; i++)
            {
                Console.WriteLine("Enter Product["+(i+1)+"] Details");
                p[i] = new Product();
                Console.WriteLine();
            }

            for (int i = 0;i < p.Length;i++)
            {
                Console.WriteLine("Product[" + (i + 1) + "] Details");
                p[i].showData();
                Console.WriteLine();
            }*/
            Product p1 = new Product();
            p1.showData();
        }
    }
}

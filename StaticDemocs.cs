using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVB
{
    public static class Author
    {
        public static string aname = "XYZ";
        public static string title = "C# Programming";
        

        public static void Update()
        {
            aname = "ABC";
        }
        public static void Display()
        {
            Console.WriteLine("Author name is: " + aname);
            Console.WriteLine("Author title is: " + title);
        }
    }
    internal class StaticDemocs
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Author Imformation: ");
            Author.Display();
            Console.WriteLine();
            Console.WriteLine("Updated Author Imfprmation");
            Author.Update();
            Author.title = "Windows Programming";
            Author.Display();
        }
    }
}

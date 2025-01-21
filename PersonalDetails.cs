using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVB
{
    internal class PersonalDetails
    {
        static void Main(string[] args)
        {
            string eno;
            string name;
            int rollno;
            int age;
            string branch;
            int sem;
            double cgpa;
            string city;

            Console.WriteLine("Eneter your enrrolment number: ");
            eno = Console.ReadLine();

            Console.WriteLine("Enter your name");
            name = Console.ReadLine();

            Console.WriteLine("Enter Roll Number: ");
            rollno = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter age: ");
            age = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter your branch");
            branch = Console.ReadLine();

            Console.WriteLine("Enter semester: ");
            sem = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter CGPA: ");
            cgpa = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter City: ");
            city = Console.ReadLine();

            Console.WriteLine("Enrolment Number is "+eno);
            Console.WriteLine("Nmae: " + name);
            Console.WriteLine("Roll Number: " + rollno);
            Console.WriteLine("Age is " + age);
            Console.WriteLine("Branch: "+branch);
            Console.WriteLine("Semester: "+sem);
            Console.WriteLine("CGPA: "+cgpa);
            Console.WriteLine("City: "+city);
        }
    }
}

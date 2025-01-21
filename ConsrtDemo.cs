using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVB
{
   
    public class Student
    {
        int rlno;
        string name;
        int sem;
        double cgpa;

        /*public Student()
        {
            Console.WriteLine("Enter Roll Number of the studnet: ");
            rlno = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name of the student: ");
            name =Console.ReadLine();
            Console.WriteLine("Enter the semester of student");
            sem = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter th cgpa of the student: ");
            cgpa = Double.Parse(Console.ReadLine());
        }*/

        public Student(int rlno, string name, int sem, double cgpa)
        {
            this.rlno = rlno;
            this.name = name;
            this.sem = sem;
            this.cgpa = cgpa;
        }

        public void showData()
        {
            Console.WriteLine("Roll Number is: " + rlno);
            Console.WriteLine("Name is: " + name);
            Console.WriteLine("Smester is: " + sem);
            Console.WriteLine("Cgpa is: " + cgpa);
        }
    }
    internal class ConsrtDemo
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the student1 Details: ");
            Student s1 = new Student(2,"Prince",4,8.20);
           // Console.WriteLine();

           // Console.WriteLine("Enter the student2 Details: ");
            Student s2 = new Student(28,"Nirav",4,8.20);
           // Console.WriteLine();
            Console.WriteLine("Student1 Detials: ");
            s1.showData();

            Console.WriteLine();
            Console.WriteLine("Student12 Detials: ");
            s2.showData();
        }
    }
}

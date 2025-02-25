using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVB
{
    public class Student1
    {
        int rlno;
        string name;
        double cgpa;

        public int Rlno
        {
            get { return rlno; }
            set { rlno = value; }
        }

        public string Name
        {
            get { return name; }
            set{name = value;}
        }

        public double Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }

        public void showData()
        {
            Console.WriteLine(rlno +"\t"+name+"\t"+cgpa);
        }
    }
    internal class PropertyDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rollno \t name \t cgpa");
            Student1 st1 = new Student1();
            st1.Rlno = 1;
            st1.Name = "Prince";
            st1.Cgpa = 8.1;
            st1.showData();

            Student1 st2 = new Student1();
            st2.Rlno = 2;
            st2.Name = "Nirav";
            st2.Cgpa = 8.1;
            st2.showData();

            Student1 st3 = new Student1();
            st3.Rlno = 3;
            st3.Name = "Sachin";
            st3.Cgpa = 7.6;
            st3.showData();

        }

    }
}

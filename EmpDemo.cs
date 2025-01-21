using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVB
{
    class Employee
    {
        int emp_id;
        string name;
        int age;
        string gender;
        int salary;
        string city;

        public void getData(int emp_id,string name,int age,string gender,int salary,string city)
        {
            this.emp_id = emp_id;
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.salary = salary;
            this.city = city;
        }
        public int getAge()
            { return age; }
        public void showData()
        {
            Console.WriteLine("Employee Id: " + emp_id);
            Console.WriteLine("Employee name: " + name);
            Console.WriteLine("Employee age: " + age);
            Console.WriteLine("Employee Gender: " + gender);
            Console.WriteLine("Employee salary: " + salary);
            Console.WriteLine("Empliyee City: " + city);
        }
    }
    class EmpDemo
    {
        public static void Main(string[] args)
        {
            Employee emp = new Employee();
            
            emp.getData(01, "Meet", 20, "Male", 20000, "Rajkot");
           

            Employee emp2 = new Employee();
            
            emp2.getData(02, "Harsh", 19, "Male", 30000, "Morbi");
           

            Employee emp3 = new Employee();
            
            emp3.getData(03, "Vishasva", 30, "Female", 50000, "Rajkot");

            if(emp.getAge()>emp2.getAge())
            {
                if(emp.getAge()>emp3.getAge())
                {
                    emp.showData();
                }
            }
            else if ()
           
        }
    }
}

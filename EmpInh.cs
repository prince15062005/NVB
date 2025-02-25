using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVB
{
    public class Employees
    {
        public int eid;
        public string name;
        double baseSalary;

        public Employees(int eid, string name, double baseSalary)
        {
            this.eid = eid;
            this.name = name;
            this.baseSalary = baseSalary;
        }
    }
    public class salary : Employees
    {
        double da;
        double hra;
        double grossSalary;

        public salary(int eid, string name, double baseSalary) : base(eid, name , baseSalary)
        {
            da = baseSalary * 0.4;
            hra = baseSalary * 0.2;
            grossSalary = baseSalary + da + hra;

        }

        public void showEmp()
        {
            Console.WriteLine(eid + "\t" + name + "\t" + grossSalary);
        }
    }
    internal class EmpInh
    {
        public static void Main(string[] args)
        {
            salary s = new salary(01,"Prince", 10000);
            Console.WriteLine("Eid \t Name \t GrossSalary");
            s.showEmp();
        }
    }
}

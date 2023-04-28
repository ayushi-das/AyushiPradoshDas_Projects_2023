using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoImplementedProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.Write("Enter ecode:");
            emp.Ecode=int.Parse(Console.ReadLine());
            Console.Write("Enter ename:");
            emp.Ename = Console.ReadLine();
            Console.Write("Enter salary:");
            emp.Salary = int.Parse(Console.ReadLine());
            Console.Write("Enter deptid:");
            emp.Deptid = int.Parse(Console.ReadLine());

            //display
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}",emp.Ecode,emp.Ename,emp.Salary,emp.Deptid,emp.GetBonus());




            //object initializer syntax
            //Employee emp2 = new Employee();
            //emp2.Ecode = 102;
            //emp2.Ename = "raman";
            //emp2.Salary = 2222;
            //emp2.Deptid = 202;

            //Object-Initializer Syntax
            //Employee emp2 = new Employee {Ecode = 102,Ename = "Raman",Salary = 2222,Deptid = 202};
            //OR
            Employee emp2 = new Employee 
            { 
                Ecode = 102, 
                Ename = "Raman", 
                Salary = 2222, 
                Deptid = 202 
            };

        }
    }

    class Employee
    {
        public int Ecode { get; set; }  
        public string Ename { get; set; }
        public int Salary { get; set; }
        public int Deptid { get; set; }

        public double GetBonus()
        {
            double bonus = 0;
            if(Salary>5000)
            {
                bonus = Salary * 0.1;
            }
            else
            {
                bonus = Salary * 0.2;
            }
            return bonus;
        }       
    }
}

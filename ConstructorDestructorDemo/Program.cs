using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDestructorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee e1 = new Employee(101, "Ramnath", 1111, 201);            
            e1.Display();
            //GC.SuppressFinalize(e1);
            //Employee e2 = new Employee(101, "Ravi", 2222, 202);
            //e2.Display();

            Employee e2 = e1;
            e1 = null;

            GC.Collect(); //forced garbage collection
            Console.WriteLine("e1 got deallocated");
            Console.ReadLine();

            
            Console.WriteLine("e2 got deallocated");


          


        }
    }

    class Employee
    {

        public int Ecode { get; set; }
        public string Ename { get; set; }
        public int Salary { get; set; }
        public int Deptid { get; set; }

        //.net object
        //File f1, con, GDI, socket
        public Employee(int ec, string en, int sal, int did)
        {
            Console.WriteLine("constructor is called");
            Ecode = ec;
            Ename = en;
            Salary = sal;
            Deptid = did;
        }    
        private double GetBonus()
        {
            return 0.1 * Salary;
        }

        public void Display()
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}",Ecode,Ename,Salary,Deptid,GetBonus());
        }

        ~Employee()
        {
            Console.WriteLine("destructor is called");
        }
    }

    class Test
    {

    }
}

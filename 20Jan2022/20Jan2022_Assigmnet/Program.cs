using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Jan2022_Assigmnet
{
    internal class Program
    {
        enum dept
        {
            account=201,
            admin=203,
            sales=204,
            others=205,


        }
        static void Main(string[] args)
        {
            string ecode, ename;
            int salary,deptid;
            double bonus;
            Console.WriteLine("Enter the ecode");
            ecode=Console.ReadLine();
            Console.WriteLine("Enter the ename");
            ename = Console.ReadLine();
            Console.WriteLine("Enter the deptid");
            deptid =int.Parse( Console.ReadLine());
            Console.WriteLine("enter the salary");
            salary =int.Parse(Console.ReadLine());

            switch (deptid){
                case (int)dept.account:
                    bonus = 0.1*(salary);
                    Console.WriteLine("Bonus of the employee "+ bonus);
                    break;
                case (int)dept.admin:
                    bonus = 0.2 * (salary);
                    Console.WriteLine("Bonus of the employee "+ bonus);
                    break;
                case (int)dept.sales:
                    bonus = 0.3 * (salary);
                    Console.WriteLine("Bonus of the employee "+ bonus);
                    break;
                    default:bonus = 0;
                    Console.WriteLine("Bonus of the employee "+ bonus);
                    break;

            }




        }
    }
   
}

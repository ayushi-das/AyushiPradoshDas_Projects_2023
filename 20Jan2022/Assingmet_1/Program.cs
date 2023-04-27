using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingmet_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int []marks=new int[5];
            int tot = 0;
            int avg;
            bool res;
            Console.WriteLine("enter the marks");
            for(int i = 0; i < 5; i++)
            {
                marks[i]=int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                if (marks[i] < 35) { res = false; }
                else if (marks[i] > 35||marks[i]<50) { res = false; }
                else { res = true; }
            }
            Console.Write("Marks ");

            for (int i = 0; i < 5; i++)
            {
                Console.Write(" "+marks[i]);
            }
           Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                tot+=marks[i];
                
            }
            Console.WriteLine("Total marks: "+tot);
            
           
            
            Console.WriteLine("Average Marks "+tot/5);

            if (res = true) Console.Write("Result: Pass");
            else Console.Write("Result: Fail");
            



        }
    }
}

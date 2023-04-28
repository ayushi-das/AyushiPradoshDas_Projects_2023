using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key;
            int value;
            int max = 0;
            String comp=" ";
            Dictionary<string,int> company = new Dictionary<string,int>();
            Console.WriteLine("Enter the Number of comapnies:");
            int noOfCompany;
            noOfCompany=int.Parse(Console.ReadLine());
            for(int i = 0; i < noOfCompany; i++)
            {
                Console.WriteLine("Eneter the comapny name");
                key = Console.ReadLine();
                Console.WriteLine("Eneter the no. of offers");
                value = int.Parse(Console.ReadLine());
                company.Add(key, value);
            }
            foreach(var v in company)
            {
                
               
                if (v.Value > max)
                {
                    max = v.Value;
                    
                }
               
            }
            Console.WriteLine(max);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] seat = new int[10, 15];
            int flag=0;
            int seat_number,temp;
            while (true) {
                seat_number = int.Parse(Console.ReadLine());
                temp = seat_number;
                if (temp == seat_number)
                {
                    flag = 1;
                    Console.WriteLine("Seat is not available!");
                    break;
                }
                else { Console.WriteLine("Seat is booked!"); }
                
            }
        }
    }
}

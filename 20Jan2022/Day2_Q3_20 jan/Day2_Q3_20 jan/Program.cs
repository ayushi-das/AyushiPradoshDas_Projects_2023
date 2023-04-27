using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Q3_20_jan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                int a;
                int seat;
                int[,] arr = new int[10, 15];
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 15; j++)
                    {
                        arr[i, j] = 0;
                    }
                }
                do
                {
                    Console.WriteLine("Enter your choice : \n 1. Book Tickets \n 2. Exit");
                    a = int.Parse(Console.ReadLine());
                    switch (a)
                    {
                        case 1:
                            Console.WriteLine("\nEnter your seat number : ");
                            seat = int.Parse(Console.ReadLine());
                            int tens = seat / 10;
                            int ones = seat % 10;
                            if (arr[tens + 1, ones] == 0)
                            {
                                Console.WriteLine("Seat Booked\n");
                                arr[tens + 1, ones] = 1;
                            }
                            else
                            {
                                Console.WriteLine("Seat not available\n");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Exited\n");
                            break;

                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }
                }
                while (a != 2);
            }
        }
    }


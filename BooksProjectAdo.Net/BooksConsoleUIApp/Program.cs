using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CRUDOperationsBooksProj;
using BooksBusinessLib;
//connected mode
namespace BooksConsoleUIApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            do
            {

                Console.WriteLine("WELCOME");
                Console.WriteLine("1. ADD MORE BOOKS");
                Console.WriteLine("2. DISPLAY ALL BOOKS");
                Console.WriteLine("3. FIND A BOOK BY BOOK CODE");
                Console.WriteLine("4. FIND A BOOK BY BOOK NAME");
                Console.WriteLine("5. UPDATE A BOOK");
                Console.WriteLine("6. DELETE A BOOK");
                Console.WriteLine("7. EXIT");
                Console.WriteLine();
                Console.WriteLine("Enter your choice!");

                choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        //adding books
                        AddBooks();
                        break;
                    case 2:
                        DisplayAll();
                        break;
                    case 3:
                        GetBooksByBookCode();
                        break;
                    case 4:
                        GetBooksByBookName();
                        break;
                    case 5:
                        UpdateBooks();
                        break;
                    case 6:
                        DeleteById();
                        break;
                    case 7:
                        Console.WriteLine("THANK YOU");
                        break;
                    default:
                        Console.WriteLine("INVALID CHOICE");
                        break;
                }
            } while (choice != 7);

        }
        static void AddBooks()
        {
            try
            {


                Books b = new Books();
                Console.Write("Enter Book Code :");
                b.BookCode = Console.ReadLine();
                Console.Write("Enter Book Name :");
                b.BookName = Console.ReadLine();
                Console.Write("Enter Publisher Name :");
                b.PublisherName = Console.ReadLine();
                Console.Write("Enter Author Name :");
                b.AuthorName = Console.ReadLine();
                Console.Write("Enter Price :");
                b.Price = int.Parse(Console.ReadLine());

                Console.WriteLine();
                BooksBusinessLayer bll = new BooksBusinessLayer();
                int count = bll.AddBooks(b);
                Console.WriteLine("Book inserted succesfully,Books record affected:" + count);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("==============================================================");
         }

        static void DeleteById()
        {
            try
            {
                //take input for ecode for deletion
                Console.WriteLine("Enter Book Code for delete:");
                string bookCode = Console.ReadLine();
                //delete using business layer
                BooksBusinessLayer bll = new BooksBusinessLayer();
                var count = bll.DeleteById(bookCode);
                Console.WriteLine("BOOK DELETED , BOOK RECORDS AFFECTED:" + count);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("====================================");
        }

        static void DisplayAll()
        {
            BooksBusinessLayer bll = new BooksBusinessLayer();
            var books = bll.GetAllBooks();
            if (books.Count != 0)
            {
                foreach (var b in books)
                {
                    Console.WriteLine($"{b.BookCode}\t{b.BookName}\t{b.PublisherName}\t{b.AuthorName}\t{b.Price}");
                }
            }
            else
            {
                Console.WriteLine("NO BOOKS  IN THE DATABASE ");
            }
            Console.WriteLine("====================================================");
        }

        static void GetBooksByBookCode()
        {
            try
            {
                //take ecode input for searching employee
                Console.Write("Enter Book Code for search:");
                string bookcode = Console.ReadLine();
                //get the employee using business layer
                var bll = new BooksBusinessLayer();
                var b = bll.GetBooksByBookCode(bookcode);
                if (b != null)
                {
                    Console.WriteLine($"{b.BookCode}\t{b.BookName}\t{b.PublisherName}\t{b.AuthorName}\t{b.Price}");
                }
                else
                {
                    Console.WriteLine("NO BOOKS FOUND");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("============================================================================");
        }

        static void GetBooksByBookName()
        {
            try
            {
                //take ecode input for searching employee
                Console.Write("Enter Book Name for search:");
                string bookname = Console.ReadLine();
                //get the employee using business layer
                var bll = new BooksBusinessLayer();
                var b = bll.GetBooksByBookName(bookname);
                if (b != null)
                {
                    Console.WriteLine($"{b.BookCode}\t{b.BookName}\t{b.PublisherName}\t{b.AuthorName}\t{b.Price}");
                }
                else
                {
                    Console.WriteLine("NO BOOKS FOUND");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("===========================================================================");
        }

        static void UpdateBooks()
        {
            try
            {


                //take books input data
                Books b = new Books();
                Console.Write("Enter Book Code for update:");
                b.BookCode = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Enter Book Name:");
                b.BookName = Console.ReadLine();
                Console.Write("Enter Publisher Name:");
                b.PublisherName = Console.ReadLine();
                Console.Write("Enter Author Name:");
                b.AuthorName = Console.ReadLine();
                Console.Write("Enter Price:");
                b.Price = int.Parse(Console.ReadLine());

                //insert using business layer
                BooksBusinessLayer bll = new BooksBusinessLayer();
                int count = bll.UpdateBooks(b);
                Console.WriteLine("Book Record updated succesfully, Books record affected:" + count);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("======================================================");
        }
    }
}

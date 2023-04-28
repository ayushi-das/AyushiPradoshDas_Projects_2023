
//Linq_assingment
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_assingment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("Enter 1 to Display all the Books");
                Console.WriteLine("Enter 2 to Search Book using Book Code");
                Console.WriteLine("Enter 3 to Sarch Books between Price Range");
                Console.WriteLine("Enter 4 to EXIT");
                Console.Write("\nEnter your Choice : ");
                choice = int.Parse(Console.ReadLine());
                BookImplementation bi = new BookImplementation();
                switch (choice)
                {
                    case 1:
                        //DISPLAY
                        var b = bi.DisplayBook();
                        DisplayList(b);
                        break;
                    case 2:
                        //DISPLAY USING CODE
                        Console.WriteLine("Enter Book Code : ");
                        string s = Console.ReadLine();
                        var bo = bi.GetBookByCode(s);
                        DisplayList(bo);
                        break;
                    case 3:
                        //DISPLAY BETWEEN PRICE
                        Console.WriteLine("Enter Start Range");
                        double start = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter End Range");
                        double end = double.Parse(Console.ReadLine());
                        var boo = bi.DisplaybetweenPrice(start, end);
                        DisplayList(boo);
                        break;
                    default:
                        break;
                }
            } while (choice != 4);
        }
        static void DisplayList(List<Book> b)
        {
            foreach (var i in b)
            {
                Console.WriteLine($"{i.BookCode}\t{i.BookName}\t{i.PublisherName}\t{i.AuthorName}\t{i.Price}");
            }
        }
    }
    class BookImplementation
    {
        List<Book> books = new List<Book>();
        public BookImplementation()
        {
            books.Add(new Book() { BookCode = "ASPNA", BookName = "ASP.Net Professional", PublisherName = "Wrox", AuthorName = "Bill Evjen, Matt Gibbs", Price = 750.00 });
            books.Add(new Book() { BookCode = "ASPNB", BookName = "Beginning ASP .NET", PublisherName = "TechMedia", AuthorName = "Dan Wahlin, Dave Reed", Price = 545.00 });
            books.Add(new Book() { BookCode = "LNQA", BookName = "Learning LINQ", PublisherName = "APress", AuthorName = "Steve Eichert", Price = 400.00 });
            books.Add(new Book() { BookCode = "CSPN", BookName = "C# Developers Guide", PublisherName = "Tata McGraw", AuthorName = "Dan Maharry", Price = 675.00 });
        }
        public List<Book> GetBookByCode(string id)
        {
            var book = (from b in books
                        where b.BookCode == id || b.BookName.Contains(id)
                        select b).ToList();
            
            return book;
        }
        public List<Book> DisplaybetweenPrice(double start, double end)
        {
            var book1 = (from b in books
                         where b.Price >= start && b.Price <= end
                         select b).ToList();
        
            return book1;
        }
        public List<Book> DisplayBook()
        {
            return books;
        }
    }
}
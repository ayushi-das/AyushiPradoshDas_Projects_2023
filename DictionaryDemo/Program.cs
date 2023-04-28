using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int,string> books = new Dictionary<int,string>();
            books.Add(1001, "Learning C#");
            books.Add(2001, "ASP.NET for Beginners");
            books.Add(3002, "Working with SQL Server");
            books.Add(4005, "Basics of ADO.NET");

            //=====================using foreach==========================
            Console.WriteLine("Traversing using foreach keys");
            foreach (var k in books.Keys)
            {
                Console.WriteLine("BookId   :" + k);
                Console.WriteLine("Book Name:" + books[k]);
                Console.WriteLine("=======================================");
            }

            Console.WriteLine("\nTraversing using foreach values");
            foreach (var v in books.Values)
            {                
                Console.WriteLine("Book Name:" + v);               
            }

            Console.WriteLine("\nTraversing using foreach key-values");
            foreach (var kv in books)
            {
                Console.WriteLine("Book Id  :" + kv.Key);
                Console.WriteLine("Book Name:" + kv.Value);
                Console.WriteLine("===================================");
            }

            //=====================using IEnumerator<>==========================
            Console.WriteLine("\nTraversing using IEnumerator of Keys");
            var ien_k = books.Keys.GetEnumerator();
            while (ien_k.MoveNext())
            {
                int k=ien_k.Current;
                Console.WriteLine(k + ":" + books[k]);
            }

            Console.WriteLine("\nTraversing using IEnumerator of Values");
            var ien_v = books.Values.GetEnumerator();
            while (ien_v.MoveNext())
            {
                string v = ien_v.Current;
                Console.WriteLine(v);
            }

            Console.WriteLine("\nTraversing using IEnumerator of Keys-Values");
            var ien_kv = books.GetEnumerator();
            while(ien_kv.MoveNext())
            {
                var kv = ien_kv.Current;
                Console.WriteLine(kv.Key +":" + kv.Value);
            }
        }
    }
}

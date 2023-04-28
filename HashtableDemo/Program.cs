using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashtableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht=new Hashtable ();
            ht.Add("username", "Administrator");
            ht.Add("password", "admin123");
            ht.Add("server", "localhost");            

            Console.WriteLine("Username:"+ ht["username"].ToString());
            Console.WriteLine("Password:" + ht["password"].ToString());
            Console.WriteLine("Server  :" + ht["server"].ToString());


        }
    }
}

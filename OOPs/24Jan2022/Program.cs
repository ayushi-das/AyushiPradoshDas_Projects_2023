using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Jan2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, pasw, conpsw, email;
            Console.Write("Enter the user name: ");
            name = Console.ReadLine();
            Console.Write("Enter the Password: ");
            pasw = Console.ReadLine();
            Console.Write("Confirm your passowd: ");
            conpsw = Console.ReadLine();
            Console.Write("Enter the user email id: ");
            email = Console.ReadLine();
            
            UserInfo user=new UserInfo();
            user.RegisterUser(name, pasw, conpsw,email);
            user.IsPasswordMatches();
            user.Display();


        }
    }
    class UserInfo
    {
        string userName, password,confirm_password,emailid;

        public void RegisterUser(string name,string pas,string conpswd,string email_id)
        {

            userName = name;

            password = pas;
            confirm_password = conpswd;


            emailid = email_id;

        }
        public bool IsPasswordMatches()
        {
            if (password == confirm_password) { return true; }
            else { return false; }
        }
        public void Display()
        {
            if (IsPasswordMatches())
            {
                Console.WriteLine("User Registerd sucessfully");
            }
            else { Console.WriteLine("Mismatch Password!\tCould not register the user"); }
        }

    }
}

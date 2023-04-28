using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C_Sharp_Assignment_24_01_22_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[1];
            UserBO userbo = new UserBO();
            users = userbo.Add("User 1", 12345, "USER 1", "aaa", users);
            users = userbo.Add("User 2", 12346, "USER 2", "bbb", users);

            users = userbo.Add("User 3", 12347, "USER 3", "ccc", users);

            users = userbo.Add("User 4", 12348, "USER 4", "ddd", users);

            userbo.Display(users);

        }
    }
    class User
    {
        public string Name { get; set; }
        public long MobileNo { get; set; }

        public string Username { get; set; }

        public string password { get; set; }

    }
    class UserBO
    {
        public User[] Add(string name, long mobilenumber, string password, string username, User[] users)
        {
            int initialsize = users.Length;
            User user = new User { Name = name, MobileNo = mobilenumber, Username = username, password = password };
            users[initialsize - 1] = user;


            User[] updateduser = new User[initialsize + 1];
            for (int i = 0; i < users.Length; i++)
            {
                updateduser[i] = users[i];
            }
           
            return updateduser;
        }
        public void Display(User[] users)
        {
            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine("{0}\t {1} \t {2} \t{3} \t{4}", i + 1, users[i].Name, users[i].Username, users[i].MobileNo, users[i].password);
            }

        }
    }

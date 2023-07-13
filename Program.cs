using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 3)
            {
                string username, password;
                Console.WriteLine("Enter the username");
                username = Console.ReadLine();
                Console.WriteLine("Enter the password");
                password = Console.ReadLine();
                if (username == "john" && password == "pass123")
                {
                    Console.WriteLine("Login Successful");
                    break;
                }
                else if (username == "john" && password != "pass123")
                {
                    Console.WriteLine("Invalid Password");
                    i++;
                }
                else
                {
                    Console.WriteLine("Invalid username");
                    i++;
                }
            }
            if (i >= 3)
            {
                Console.WriteLine("Login failed");
            }
           Console.ReadKey();

        }



    }
}


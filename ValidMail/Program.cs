using System;

namespace ValiMail
{
    class Program
    {
        static void Main(string[] args)
        {
            string mail = "cavid@code.edu.az";
            string pass = "123456";

            CheckingMailandPass("cavid@code.edu.az", "123124135");
        }
        static void CheckingMailandPass(string mail, string pass)
        {
            if (mail == "cavid@code.edu.az" && pass == "123456")
            {
                Console.WriteLine("Signed in");
            }
            else
            {
                Console.WriteLine("Login or pass is incorrect");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringPractice2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your first name?");

            string firstname = Console.ReadLine();

            Console.WriteLine("Your firstname is: " + firstname);
            
            Console.WriteLine("What is your last name?");

            string lastname = Console.ReadLine();

            Console.WriteLine("Your last name is: " + lastname);

            Console.WriteLine("Your whole name is: " + firstname.ToLower() + " " + lastname.ToLower());

            if (firstname.Length > lastname.Length) Console.WriteLine("Your first name is longer than your last name.");
            if (firstname.Length < lastname.Length) Console.WriteLine("Your last name is longer than your first name.");
            if (firstname.Length == lastname.Length) Console.WriteLine("Your first name and last name are equalin length.");
            {


            }



            
        }
    }
}

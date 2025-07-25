using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Activity_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;

            Console.Write("Enter first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            lastName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                Console.WriteLine("Input fields cannot be empty.");
            }
            else
            {
                Console.WriteLine($"Your full name is: {firstName} {lastName}");
            }
        }
    }
}
        

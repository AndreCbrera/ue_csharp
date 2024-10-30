// See https://aka.ms/new-console-template for more information
// This is a one way
// Console.WriteLine("Hello, World!");

using System;

namespace DisplayVars
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Andrés ";
            string lastName = "Cabrera";
            string fullName = firstName + lastName;

            Console.WriteLine(fullName + "\n");

            int x = 19;
            int y = 10;
            Console.WriteLine(x + y);
        }
    }
}

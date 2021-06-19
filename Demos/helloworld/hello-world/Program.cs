using System;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Change it as you want");

            

            Console.WriteLine($"Enter your age:");
            string myAge = Console.ReadLine ();

            Console.WriteLine($"Enter your name:");
            string myName = Console.ReadLine();

            Console.WriteLine($"Your age is {myAge} and your name is {myName}");


        }
    }
}

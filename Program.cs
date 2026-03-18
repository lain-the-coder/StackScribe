using System;

namespace StackScribe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is my StackScribe application");
            if (args.Length == 0)
            {
                Console.WriteLine("No command line arguments");
            }
            else
            {
                foreach(var arg in args)
                {
                    Console.WriteLine($"Argument: {arg}");
                }
            }
        }
    }
}
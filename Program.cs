using System;

namespace StackScribe
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document();
            Console.WriteLine("Welcome to StackScribe!");
            CommandsList();
            while (true)
            {
                Console.Write("> ");
                string? input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("No arguments passed. Please enter a command.");
                    CommandsList();
                    continue;
                }
                string[] inputList = input.Split(' ');
                string command = inputList[0].ToLower();
                if (command == "insert")
                {
                    int lineNumber = int.Parse(inputList[1]);
                    string text = String.Join(" ", inputList, 2, inputList.Length - 2);
                    document.Addline(lineNumber, text);
                    Console.WriteLine($"Added line {lineNumber}: {text}");
                    continue;
                }
                if (command == "show")
                {
                    document.ShowAll();
                    continue;
                }
                if (command == "help")
                {
                    CommandsList();
                    continue;
                }
                if (command == "exit")
                {
                    Console.WriteLine("Exiting program.");
                    break;
                }
                if (command != "insert" && command != "show" && command != "help" && command != "exit")
                {
                    Console.WriteLine($"Unknown command: {command}");
                    CommandsList();
                    continue;
                }
            }
        }
        static void CommandsList()
        {
            Console.WriteLine("Available commands:");
            Console.WriteLine("1. insert <line number> <text> - Adds a line of text at the specified line number.");
            Console.WriteLine("2. show - Displays all lines in the document.");
            Console.WriteLine("3. help - Displays this list of commands.");
            Console.WriteLine("4. exit - Exits the program.");
        }
    }
}
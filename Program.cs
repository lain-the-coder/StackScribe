using System;
using System.Collections;
using System.Collections.Generic;

namespace StackScribe
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document();
            Stack<InsertCommand> stack = new Stack<InsertCommand>();
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
                    var cmd = new InsertCommand(document, lineNumber, text);
                    cmd.Execute();
                    stack.Push(cmd);
                    continue;
                }
                if (command == "remove")
                {
                    int lineNumber = int.Parse(inputList[1]);
                    document.Removeline(lineNumber);
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
            // List of available commands
            Console.WriteLine("Available commands:");
            Console.WriteLine("1. insert <line number> <text> - Adds a line of text at the specified line number.");
            Console.WriteLine("2. remove <line number> - Removes the line at the specified line number.");
            Console.WriteLine("3. show - Displays all lines in the document.");
            Console.WriteLine("4. help - Displays this list of commands.");
            Console.WriteLine("5. exit - Exits the program.");
        }
    }
}
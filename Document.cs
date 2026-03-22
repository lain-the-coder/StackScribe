using System;
using System.Collections.Generic;

namespace StackScribe
{
    public class Document
    {
        // List of lines in the document
        private List<string> lines = new List<string>();

        public void Addline(int lineNumber, string text)
        {
            if (lineNumber < 1 || lineNumber > lines.Count + 1)
            {
                Console.WriteLine("Invalid line number");
                return;
            }
            else
            {
                lines.Insert(lineNumber - 1, text);
                Console.WriteLine($"Added line {lineNumber}: {text}");
            }
        }
        public void Removeline(int lineNumber)
        {
            if (lineNumber < 1 || lineNumber > lines.Count)
            {
                Console.WriteLine("Invalid line number");
                return;
            }
            else
            {
                lines.RemoveAt(lineNumber - 1);
                Console.WriteLine($"Removed line {lineNumber}.");
            }
        }
        public void ShowAll()
        {
            if (lines.Count == 0)
            {
                Console.WriteLine("Document is empty");
            }
            else
            {
                for (int i = 0; i < lines.Count; i++)
                {
                    Console.WriteLine($"{i+1}: {lines[i]}");
                }
            }
        }
    }
}
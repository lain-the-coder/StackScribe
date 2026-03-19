using System;
using System.Collections.Generic;

namespace StackScribe
{
    public class Document
    {
        private List<string> lines = new List<string>();

        public void Addline(int lineNumber, string text)
        {
            lines.Insert(lineNumber-1, text);
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
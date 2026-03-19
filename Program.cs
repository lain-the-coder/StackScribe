using System;

namespace StackScribe
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document();
            document.ShowAll();
            document.Addline(1, "Hello World!");
            document.Addline(2, "This is a test document.");
            document.Addline(3, "It is a simple document, with a few lines of text.");
            document.ShowAll();
        }
    }
}
using System;

namespace StackScribe
{
    public class InsertCommand
    {
        private Document _document;
        private int _lineNumber;
        private string _text;
        public InsertCommand(Document document, int lineNumber, string text)
        {
            _document = document;
            _lineNumber = lineNumber;
            _text = text;
        }
        public void Execute()
        {
            _document.Addline(_lineNumber, _text);
        }
        public void Undo()
        {
            _document.Removeline(_lineNumber);
        }
    }
}
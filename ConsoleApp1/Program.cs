using System;
namespace HomeWork
{

    class DocumentProgram
    {
        public void OpenDocument()
        {
            Console.WriteLine("Document Opened");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Can Edit in Pro and Expert versions");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Can Save in Pro and Expert versions");
        }

    }
    class ProDocumentProgram : DocumentProgram
    {
        public override void EditDocument()
        {
            Console.WriteLine("Document Edited");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");
        }
    }
    class ExpertDocumentProgram : ProDocumentProgram
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in pdf format");
        }
    }
    class Program
    {

        static void Main()
        {
            Console.WriteLine("Write Your Key");
            string key = Console.ReadLine();
            switch (key)
            {
                case "basic":
                    DocumentProgram documentProgram = new DocumentProgram();
                    documentProgram.OpenDocument();
                    documentProgram.SaveDocument();
                    documentProgram.EditDocument();
                    break;
                case "pro":
                    DocumentProgram document = new ProDocumentProgram();
                    document.OpenDocument();
                    document.SaveDocument();
                    document.EditDocument();
                    break;
                case "expert":
                    DocumentProgram program = new ExpertDocumentProgram();
                    program.OpenDocument();
                    program.SaveDocument();
                    program.EditDocument();
                    break;
                default:
                    break;
            }
        }
    };
}

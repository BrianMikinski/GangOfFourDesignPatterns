using System;

namespace GangOfFourDesignPatterns.Structural
{
    public class DocumentPrinter
    {
        public void PrintDocument(IDocument document)
        {
            Console.WriteLine("Printing document...\n");
            Console.WriteLine($"Policy Holder: {document.PolicyHolder()}");
            Console.WriteLine($"Policy Holder Address: {document.PolicyHolderAddress()}");
            Console.WriteLine($"Policy Amount: {document.PolicyAmount()}\n");
        }
    }
}
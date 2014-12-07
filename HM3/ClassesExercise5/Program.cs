using System;

namespace ClassesExercise5
{
    class Program
    {
        static void Main()
        {
            Invoice invoice = new Invoice(1, "Silpo");
            invoice.Article = "Milk";
            invoice.Quantity = 200;
            invoice.PricePerUnit = 15;

            invoice.PrintInvoiceSummary();

            Console.ReadKey();
        }
    }
}

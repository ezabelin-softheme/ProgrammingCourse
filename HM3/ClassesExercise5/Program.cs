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

            double totalInvoiceWithNDS = invoice.CountTotalInvoice(true);
            double totalInvoiceWithoutNDS = invoice.CountTotalInvoice(false);


            Console.WriteLine("Total invoice for customer {0}({1}) for {2} quantity of {3} with price {4} grn per unit:",
                invoice.Customer, invoice.Account, invoice.Quantity, invoice.Article, invoice.PricePerUnit);
            Console.WriteLine("with NDS - {0} grn", totalInvoiceWithNDS);
            Console.WriteLine("without NDS - {0} grn", totalInvoiceWithoutNDS);

            Console.ReadKey();
        }
    }
}

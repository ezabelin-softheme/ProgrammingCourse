using System;

namespace ClassesExercise5
{
    class Invoice
    {
        private readonly int _account;
        private readonly string _customer;
        private string _article;
        private int _quantity;
        private double _pricePerUnit;

        public Invoice(int account, string customer)
        {
            _account = account;
            _customer = customer;
        }

        public string Article
        {
            get { return _article; }
            set { _article = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public double PricePerUnit
        {
            get { return _pricePerUnit; }
            set { _pricePerUnit = value; }
        }

        public double CountTotalInvoice(bool withNds)
        {
            double totalInvoice;

            if (withNds)
            {
                totalInvoice = _quantity*_pricePerUnit*1.2;
            }
            else
            {
                totalInvoice = _quantity*_pricePerUnit;
            }

            return totalInvoice;
        }

        public void PrintInvoiceSummary()
        {
            Console.WriteLine(
                "Total invoice for customer {0}({1}) for {2} quantity of {3} with price {4} grn per unit:",
                _customer, _account, Quantity, Article, PricePerUnit);
            Console.WriteLine("with NDS - {0} grn", CountTotalInvoice(true));
            Console.WriteLine("without NDS - {0} grn", CountTotalInvoice(false));
        }
    }
}
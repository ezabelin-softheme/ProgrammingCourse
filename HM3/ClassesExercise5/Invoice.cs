
namespace ClassesExercise5
{
    class Invoice
    {
        public readonly int Account;
        public readonly string Customer;
        private string _article;
        private int _quantity;
        private double _pricePerUnit;

        public Invoice(int account, string customer)
        {
            Account = account;
            Customer = customer;
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
    }
}

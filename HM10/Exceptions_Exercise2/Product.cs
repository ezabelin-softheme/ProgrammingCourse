using System;

namespace Exceptions_Exercise2
{
    public struct Product
    {
        public string ProductName { get; set; }
        public string ShopName { get; set; }
        public int Price { get; set; }

        public void FillPriceData()
        {   
            Console.WriteLine("Enter product name");
            ProductName = Console.ReadLine();

            Console.WriteLine("Enter shop name where possible to buy this product");
            ShopName = Console.ReadLine();

            Console.WriteLine("Enter price of product");
            string enteredPrice = Console.ReadLine();
            Price = Convert.ToInt32(enteredPrice);

            Console.WriteLine(new string('-',25));
        }

        public void ShowAllInformation()
        {
            Console.WriteLine("\nProduct name - {0}\nProduct price - {1}", ProductName, Price);
        }
    }
}

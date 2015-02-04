using System;
using System.Linq;

namespace Exceptions_Exercise2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter size of products array:");
            string arraySize = Console.ReadLine();
            Product[] allProducts = new Product[Convert.ToInt32(arraySize)];
            Console.WriteLine(new string('-', 25));

            for (int i = 0; i < allProducts.Length; i++)
            {
                Product newPrice = new Product();
                newPrice.FillPriceData();
                allProducts[i] = newPrice;
            }

            allProducts = allProducts.OrderBy(p => p.ShopName).ToArray();

            Console.WriteLine("Enter shop name to see all information about products");
            string enteredShopName = Console.ReadLine();

            allProducts = allProducts.Where(a => a.ShopName == enteredShopName).ToArray();
            try
            {
                CheckShopsAndShowInfoAboutAllProducts(allProducts);
            }
            catch (ShopNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            Console.ReadKey();
        }

        static void CheckShopsAndShowInfoAboutAllProducts(Product[] productArray)
        {
            if (productArray.Any())
            {
                for (int i = 0; i < productArray.Length; i++)
                {
                    productArray[i].ShowAllInformation();
                }
            }
            else
            {
                throw new ShopNotFoundException("Sorry, but such shop is not found");
            }
        }
    }
}

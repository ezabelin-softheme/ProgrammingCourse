using System;

namespace ArraysIndexesExercise2
{
    class Article
    {
        private readonly string name;
        private readonly string storeName;
        private readonly double price;

        public Article(string name, string storeName, double price)
        {
            this.name = name;
            this.storeName = storeName;
            this.price = price;
        }

        public string Name
        {
            get { return name; }
        }

        public string StoreName
        {
            get { return storeName; }
        }

        public double Price
        {
            get { return price; }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Article info:\nName - {0}\nSelling store name - {1}\nPrice - {2}\n", Name, StoreName, Price);
        }
    }
}

using System;
using System.Text;

namespace ClassesExercise8
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введите ключ доступа:");

            string licenseKey = Console.ReadLine();
            switch (licenseKey)
            {
                case "":
                {
                    DocumentWorker documentWorker = new DocumentWorker();
                    documentWorker.OpenDocument();
                    documentWorker.EditDocument();
                    documentWorker.SaveDocument();
                    break;
                }
                
                case "pro":
                {
                    DocumentWorker proDocumentWorker = new ProDocumentWorker();
                    proDocumentWorker.OpenDocument();
                    proDocumentWorker.EditDocument();
                    proDocumentWorker.SaveDocument();
                    break;
                }

                case "exp":
                {
                    DocumentWorker expertDocumentWorker = new ExpertDocumentWorker();
                    expertDocumentWorker.OpenDocument();
                    expertDocumentWorker.EditDocument();
                    expertDocumentWorker.SaveDocument();
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}

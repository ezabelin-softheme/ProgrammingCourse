using System;
using System.Text;

namespace AbstractionExercise1
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Enter format of document:");

            string enteredValue = Console.ReadLine();
            switch (enteredValue)
            {
                case "xml":
                {
                    AbstractHandler halper = new XMLHandler();
                    halper.AllActionsChain();
                    break;
                }

                case "txt":
                {
                    AbstractHandler halper = new TXTHandler();
                    halper.AllActionsChain();
                    break;
                }

                case "doc":
                {
                    AbstractHandler halper = new DOCHandler();
                    halper.AllActionsChain();
                    break;
                }

                default:
                {
                    Console.WriteLine("Sorry, but entered format is not supported");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}

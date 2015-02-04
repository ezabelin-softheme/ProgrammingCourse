using System;
using System.Threading;

namespace Threads_Exercise2
{
    class Program
    {
        private const int MaxX = 100;
        private const int MaxY = 35;
        private static Random Random = new Random();

        static void Main()
        {
            Thread[] threadArray = new Thread[30];
            for (int i = 0; i < threadArray.Length; i++)
            {
                //Console configuration
                Console.SetWindowSize(MaxX + 1, MaxY + 1);
                Console.WindowLeft = Console.WindowTop = 0;
                Console.SetBufferSize(MaxX + 1, MaxY + 1);
                Console.CursorVisible = false;

                //Threads creating
                var sameCoordinateX = Random.Next(0, MaxX - 1);
                int stripsLength = Random.Next(10, 20);
                threadArray[i] = new Thread(() => WriteLetter(stripsLength, sameCoordinateX));
                threadArray[i].Start();
                Thread.Sleep(300);
            }
        }

        private static void WriteLetter(int counter, int coordX)
        {
            int lineSizeCounter = 0;
            int cursorX = coordX;
            int cursorY = Random.Next(0, (MaxY - 1) / 2);
            int cursorY2 = Random.Next((MaxY - 1) / 2, MaxY - 1);
            while (lineSizeCounter < counter)
            {
                char[] chars = "abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                int i = Random.Next(chars.Length);
                if (lineSizeCounter == 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (lineSizeCounter == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }

                GetValidVerticalCursorPostition(ref cursorY);
                GetValidVerticalCursorPostition(ref cursorY2);

                Console.SetCursorPosition(cursorX, cursorY);
                Console.WriteLine(chars[i]);
                Thread.Sleep(100);

                Console.SetCursorPosition(cursorX, cursorY2);
                Console.WriteLine(chars[i]);
                Thread.Sleep(100);

                lineSizeCounter++;
            }
            Console.ResetColor();
        }

        private static void GetValidVerticalCursorPostition(ref int cursorRandomY)
        {
            if (cursorRandomY < MaxY - 1)
            {
                cursorRandomY = cursorRandomY + 1;
            }
            else if (cursorRandomY >= MaxY - 1)
            {
                cursorRandomY = 0;
            }
        }
    }
}

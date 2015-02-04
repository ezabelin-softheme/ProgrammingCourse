using System;
using System.Threading;

namespace Threads_Exercise1
{
    class Program
    {
        private const int MaxX = 100;
        private const int MaxY = 35;
        private static Random _random;

        static void Main()
        {
            Thread[] threadArray = new Thread[45];
            for (int i = 0; i < threadArray.Length; i++)
            {
                //Console configuration
                Console.SetWindowSize(MaxX+1, MaxY+1);
                Console.WindowLeft = Console.WindowTop = 0;
                Console.SetBufferSize(MaxX + 1, MaxY + 1);
                Console.CursorVisible = false;

                //Threads creating
                ParameterizedThreadStart paramThread = new ParameterizedThreadStart(WriteLetter);
                threadArray[i] = new Thread(paramThread);

                //Set random length of strips
                _random = new Random();
                threadArray[i].Start(_random.Next(10, 20));
                Thread.Sleep(200);
            }
        }

        private static void WriteLetter(object counter)
        {
            int lineSizeCounter = 0;
            _random = new Random();
            int cursorX = _random.Next(0, MaxX-1);
            int cursorY = _random.Next(0, MaxY-1);
            while (lineSizeCounter < (int)counter)
            {
                char[] chars = "abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                int i = _random.Next(chars.Length);
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
                Console.SetCursorPosition(cursorX, cursorY);
                Console.WriteLine(chars[i]);
                Thread.Sleep(100);
                lineSizeCounter++;
            }
            Console.ResetColor();
        }

        private static void GetValidVerticalCursorPostition(ref int cursorRandomY)
        {
            if (cursorRandomY < MaxY-1)
            {
                cursorRandomY = cursorRandomY + 1;
            }
            else if (cursorRandomY >= MaxY-1)
            {
                cursorRandomY = 0;
            }
        }
    }
}

using System;
using System.Threading;

namespace Pract5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            ulong x = ReadX();
            string f = Convert.ToString(GetFactorial(x));

            int i = 0;


            do
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.BackgroundColor = ConsoleColor.White;

                DrowTable(f);

                GetConsoleSleepAndClear();

                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkBlue;

                DrowTable(f);

                GetConsoleSleepAndClear();

                i++;
            } while (i < 35);
        }
        static ulong GetFactorial(ulong x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * GetFactorial(x - 1);
            }
        }
        public static void WriteBoxLine(int num, char beginSym, char indentSym, char endSym)
        {
            Console.Write(beginSym);
            for (int i = 0; i < num; i++)
                Console.Write(indentSym);
            Console.WriteLine(endSym);
        }

        static ulong ReadX()
        {
            bool isSuccess;
            ulong x;
            
            do
            {
                isSuccess = ulong.TryParse(Console.ReadLine(), out x);
                if (!isSuccess)
                    Console.WriteLine("Вы промахнулись с минусом, попробуйте еще разок");
            } while (!isSuccess);
            return x;
        }
        static void DrowTable(string f)
        {
            WriteBoxLine(f.Length, '╔', '═', '╗');
            Console.WriteLine($"║{f}║");
            WriteBoxLine(f.Length, '╚', '═', '╝');
        }

        static void GetConsoleSleepAndClear()
        {
            Thread.Sleep(20);
            Console.Clear();
            Console.SetCursorPosition(0, 0);
        }
    }
}

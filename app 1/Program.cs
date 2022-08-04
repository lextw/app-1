using System;

namespace app_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int picture = 52;
            int pictureInRow = 3;
            int countFullRow;
            int balance;

            countFullRow = picture / pictureInRow;
            balance = picture % pictureInRow;

            Console.WriteLine("Полных рядов: " + countFullRow);
            Console.WriteLine("Остаток: " + balance);
        }
    }
}

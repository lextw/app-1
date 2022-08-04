using System;

namespace app_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pictureCount = 52;
            int pictureInRow = 3;
            int countFullRow;
            int remainingPictures;

            countFullRow = pictureCount / pictureInRow;
            remainingPictures = pictureCount % pictureInRow;

            Console.WriteLine("Полных рядов: " + countFullRow);
            Console.WriteLine("Остаток: " + remainingPictures);
        }
    }
}

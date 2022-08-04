using System;

namespace app_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите колличество золота: ");

            int goldCount = Convert.ToInt32(Console.ReadLine());
            int priceСrystal = 3;
            int cristalBy;
            int remainingCristal;

            if (goldCount > priceСrystal)
            {
                cristalBy = goldCount / priceСrystal;
                remainingCristal = goldCount % priceСrystal;

                Console.WriteLine("Колличество кристалов: " + cristalBy);
                Console.WriteLine("Остаток золота: " + remainingCristal);
            } 
            else
            {
                Console.WriteLine("Золота недостаточно для покупки кристалов");
            }
        }
    }
}

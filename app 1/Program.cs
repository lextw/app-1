using System;

namespace app_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите колличество золота: ");
            int golds = Convert.ToInt32(Console.ReadLine());

            int priceСrystal = 3;

            Console.WriteLine("Стоимость одного кристала = " + priceСrystal + ". Сколько кристалов хотите купить?");
            int crystalsCount = Convert.ToInt32(Console.ReadLine());

            int remainingGolds = golds - (crystalsCount * priceСrystal);

            Console.WriteLine("Колличество кристалов: " + crystalsCount);
            Console.WriteLine("Остаток золота: " + remainingGolds);
      
        }
    }
}

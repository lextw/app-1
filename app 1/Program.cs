using System;

namespace app_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как вас зовут");
            string name = Console.ReadLine();
            Console.WriteLine("Какой ваш знак зодиака");
            string zodiacSign = Console.ReadLine();
            string fullText = "Вас зовут " + name + ", вам 21 год, вы " + zodiacSign + " и работаете на заводе.";

            Console.WriteLine(fullText);
        }
    }
}

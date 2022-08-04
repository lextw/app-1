using System;

namespace app_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Kondracheno";
            string secondName = "Alex";

            Console.WriteLine(name);
            Console.WriteLine(secondName);

            string intermediateVariable = name;

            name = secondName;
            secondName = intermediateVariable;

            Console.WriteLine(name);
            Console.WriteLine(secondName);
        }
    }
}

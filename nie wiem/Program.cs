using System;

namespace nie_wiem
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("podaj pierwszą liczb");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj druga liczbe");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + b);

            Console.ReadKey();
        }
    }
}

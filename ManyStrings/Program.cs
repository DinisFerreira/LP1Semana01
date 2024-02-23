using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Um Null\0 e uma copyrightSymbol\u00A9";
            string mark ="é um Carriage return newLine \u000A";
            string tour = "a" + 2;
            string lol = "abc" + 'x';
            int x = 5;
            int y = 7;
            
            Console.WriteLine(message);
            Console.WriteLine(mark);
            Console.WriteLine(tour);
            Console.WriteLine(lol);
            Console.WriteLine($"{x} mais {y} e igual a {x + y}");
        }
    }
}

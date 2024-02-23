using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Um Null\0 e uma copyrightSymbol\u00A9";
            string mark ="é um Carriage return newLine \u000A";

            Console.WriteLine(message);
            Console.WriteLine(mark);
        }
    }
}

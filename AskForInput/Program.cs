using System;

namespace AskForInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insira um numero inteiro");
            string malta = Console.ReadLine();
            int boas = int.Parse(malta);
            Console.WriteLine("insira um numero Real");
            string Ler = Console.ReadLine();
            float fado = float.Parse(Ler);
            Console.WriteLine(boas+fado);


        }
    }
}

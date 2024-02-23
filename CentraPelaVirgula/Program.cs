using System;

namespace CentraPelaVirgula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escreva 4 numeros reais:");
            string azul = Console.ReadLine();
            string verde = Console.ReadLine();
            string rosa = Console.ReadLine();
            string preto = Console.ReadLine();

        
            float cima = float.Parse(azul);
            float baixo = float.Parse(verde);
            float esquerda = float.Parse(rosa);
            float direita = float.Parse(preto);

           
            string norte = $"{cima,6:f2}";
            string sul = $"{baixo,6:f2}";
            string este = $"{esquerda,6:f2}";
            string oeste = $"{direita,6:f2}";

            
            Console.WriteLine(norte);
            Console.WriteLine(sul);
            Console.WriteLine(este);
            Console.WriteLine(oeste);
        }
    }
}

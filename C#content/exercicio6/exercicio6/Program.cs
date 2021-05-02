using System;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCICIO 1 - Digite um número e diga todos os impares até o mesmo.

            Console.WriteLine("Digite um número:");
            int escolhaUser = int.Parse(Console.ReadLine());
            for (int cont = 1; cont <= escolhaUser; cont++)
            {
                if (cont % 2 != 0)
                {
                    Console.WriteLine(cont);
                }
            }
       
        }
    }
}

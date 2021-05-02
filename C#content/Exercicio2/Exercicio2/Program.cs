using System;
using System.Globalization;
namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCICO DE FIXAÇÂO

            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos comodos sua casa tem?");
            int comodos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto");
            float preco = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu último nome, idade e altura (Mesma linha)");
            string[] dados = Console.ReadLine().Split(' ');
            string ultimoNome = dados[0];
            int idade = int.Parse(dados[1]);
            float altura = float.Parse(dados[2], CultureInfo.InvariantCulture);
            // saida dos dados e fatiamentos...

            Console.WriteLine();
            Console.WriteLine(nome);
            Console.WriteLine(comodos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

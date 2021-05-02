using System;
using System.Globalization;
namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarando todas as variaveis
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            // Realizando exercicio

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é R$ {preco1}");
            Console.WriteLine($"{produto2}, cujo preço é R$ {preco2}");
            Console.WriteLine();
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais: {medida}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:3f}");
            Console.WriteLine(medida.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}

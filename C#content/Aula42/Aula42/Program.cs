using System;
using System.Globalization;

namespace Aula42
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler os dados de um produto em estoque
               mostrar os dados do produto
               Realizar uma entrada no estoque e mostrar novamente os dados do produto
               realizar uma saida no estoque e mostrar novamente os dados do produto
               use uma classe produto, para esse sistema. */
            Produto p;
            p = new Produto();
            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("\nPreço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("\nQuantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nDados do produto: {p} ");

            Console.WriteLine("\nDigite o número de produto a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine($"\nDados atualizados: {p} ");

            Console.WriteLine("\nDigite o número de produtos a ser removido o estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine($"\nDados atualizados: {p} ");



        }
    }
}

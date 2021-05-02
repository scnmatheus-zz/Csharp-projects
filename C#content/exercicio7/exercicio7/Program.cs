using System;
using System.Globalization;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas nomeUm, nomeDois, idadeUm, idadeDois;
            nomeUm = new Pessoas();
            nomeDois = new Pessoas();
            idadeUm = new Pessoas();
            idadeDois = new Pessoas();
            // PRIMEIRO DESAFIO SOBRE ORIENTAÇÂO A OBJETOS, IDENTIFIQUE A PESSOA MAIS VELHA.
            Console.WriteLine("Digite o nome da primeiroa pessoa: ");
            nomeUm.NomeUm = Console.ReadLine();
            Console.WriteLine($"Qual a idade de {nomeUm.NomeUm} ? ");
            idadeUm.IdadeUm = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome da segunda pessoa: ");
            nomeDois.NomeDois = Console.ReadLine();
            Console.WriteLine($"Qual a idade de {nomeDois.NomeDois} ? ");
            idadeDois.IdadeDois = int.Parse(Console.ReadLine());

            if (idadeUm.IdadeUm > idadeDois.IdadeDois)
            {
                Console.WriteLine($"Pessoa mais velha: {nomeUm.NomeUm}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {nomeDois.NomeDois}");
            }
            /* EXERCICIO 02 - Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
            médio dos funcionários. */
            Funcionarios primeiroFunc, segundoFunc, salarioPrimeiro, salarioSegundo;
            primeiroFunc = new Funcionarios();
            segundoFunc = new Funcionarios();
            salarioPrimeiro = new Funcionarios();
            salarioSegundo = new Funcionarios();
            

            Console.WriteLine("Digite o nome do primeiro funcionário: ");
            primeiroFunc.Nome = Console.ReadLine();
            Console.WriteLine("Qual o salário do primeiro funcionário : ");
            salarioPrimeiro.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o nome do segundo funcionário : ");
            segundoFunc.Nome = Console.ReadLine();
            Console.WriteLine("Qual o salário do segundo funcionário : ") ;
            salarioSegundo.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (salarioPrimeiro.Salario + salarioSegundo.Salario) / 2;
            Console.WriteLine($"Salário médio = {media.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}

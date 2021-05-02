using System;
using System.Globalization;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicio proposto 04 - descubra se um número inteiro digitado é negativo ou positivo ou nulo.
            Console.WriteLine("Bem vindo, digite um número inteiro: ");
            int num1 = int.Parse(Console.ReadLine());
            if (num1 > 0) {
                Console.WriteLine("O número digitado é POSITIVO");
            }
            else if (num1 < 0)
            {
                Console.WriteLine("O número digitado é NEGATIVO");
            }
            else if (num1 == 0)
            {
                Console.WriteLine("O número digitado é NEUTRO");
            }
            // exercicio 02 - Fazer um programa para ler um número inteiro e dizer se é par ou impar.
            Console.WriteLine("\nDigite um número inteiro: ");
            int num2 = int.Parse(Console.ReadLine());
            if (num2 % 2 == 0)
            {
                Console.WriteLine("O número digitado é PAR!");
            }
            else
            {
                Console.WriteLine("O número digitado é impar");
            }
            // exercicio 03 - fazer um programa que determine se dois números são multiplos um do outro ou não.
            Console.WriteLine("\nDigite um número inteiro:");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número inteiro: ");
            int num4 = int.Parse(Console.ReadLine());

            if (num4 % num3 == 0)
            {
                Console.WriteLine("SÂO MULTIPLOS");
            }
            else if (num3 % num4 == 0 || num4 % num3 == 0)
            {
                Console.WriteLine("SÂO MULTIPLOS");
            }
            else
            {
                Console.WriteLine("NÂO são multiplos");
            }
            /* Exercicio 04 - Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas */
            int diferenca = 0;
            Console.WriteLine("Digite a hora inicial e final de um jogo (mesma linha):");
            string[] horas = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(horas[0]);
            int horaFinal = int.Parse(horas[1]);
            if (horaInicial > horaFinal)
            {
                diferenca = horaInicial + horaFinal;
            }
            else if (horaInicial < horaFinal)
            {
                diferenca = horaFinal - horaInicial;
            }
            else
            {
                diferenca = 24;
            }
            Console.WriteLine($"O JOGO DUROU {diferenca} HORA(S)");

            Console.WriteLine("1 | CACHORRO QUENTE | R$4,00 \n2 | X-SALADA | R$4,50\n3 | X-BACON | R$5,00 \n4 | TORRADA-SIMPLES | R$2,00\n5 | REFRIGERANTE | R$1,50");
            Console.WriteLine("Digite o ID e a quantidade que deseja comprar (na mesma linha)");
            string[] valores = Console.ReadLine().Split(' ');
            int id = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);
            double preco = 0;
            if (id == 1)
            {
                preco = quantidade * 4.00;
            }
            else if (id == 2)
            {
                preco = quantidade * 4.50;
            }
            else if (id == 3)
            {
                preco = quantidade * 5.00;
            }
            else if (id == 4)
            {
                preco = quantidade * 2.00;
            }
            else if (id == 5)
            {
                preco = quantidade * 1.50;
            }
            Console.WriteLine($"O total a pagar será R${preco.ToString("F2", CultureInfo.InvariantCulture)}");



        }
    }
}

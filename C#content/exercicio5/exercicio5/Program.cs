using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* EXERCICIOS UTILIZANDO A ESTRUTURA DE REPETIÇÂO WHILE.

            Escreva um programa que informe que a senha digitada está errada, ate ser digitado o valor 2002. */
            Console.WriteLine("Bem vindo de volta! insira sua senha para logar no sistema");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha invalida, por favor tente novamente.");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Logado com sucesso");
            // EXERCICIO 02 - Um posto deseja saber qual o combustivel mais comprado, desenvolva um programa para isso.
            Console.WriteLine("Bem vindos, por favor diga qual o seu combustivel favorito [1] Alcool [2] Gasolina [3] Diesel [4] SAIR");
            int escolha = int.Parse(Console.ReadLine());
            int alcool = 0;
            int diesel = 0;
            int gasolina = 0;
            if (escolha == 1)
            {
                alcool = alcool + 1;
            }
            if (escolha == 2)
            {
                gasolina = gasolina + 1;
            }
            if (escolha == 3)
            {
                diesel = diesel + 1;
            }
            while (escolha != 4)
            {
                Console.WriteLine("Bem vindo, por favor diga seu combustivel favorito [1] Alcool [2] Gasolina [3] Diesel [4] SAIR");
                escolha = int.Parse(Console.ReadLine());
                if (escolha == 1)
                {
                    alcool = alcool + 1;
                }
                if (escolha == 2)
                {
                    gasolina = gasolina + 1;
                }
                if (escolha == 3)
                {
                    diesel = diesel + 1;
                }
            }
            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}

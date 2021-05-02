using System;
using System.Globalization;
namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 25;
            int c = a + b;
            Console.WriteLine($"A soma entre {a} e {b} é igual a {c}");

            Console.WriteLine("Digite um número ");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número ");
            double e = double.Parse(Console.ReadLine());
            double f = -d + e;

            Console.WriteLine(f);

            Console.WriteLine("ID do funcionário:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas horas foram trabalhadas? ");
            float horas = float.Parse(Console.ReadLine());
            Console.WriteLine("Quanto o funcionário recebe por hora? ");
            float sal = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            float salario = (float)horas * sal;

            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"SALÀRIO: R$ {salario.ToString("F2")}", CultureInfo.InvariantCulture);

            // ATIVIDADE 3

            Console.WriteLine("Código da peça: ");
            byte codigo = byte.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade a ser comprada: ");
            byte quantidade = byte.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor da peça? ");
            float valor = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Código da segunda peça: ");
            byte codigo2 = byte.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade a ser comprada: ");
            byte quantidade2 = byte.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor da peça? ");
            float valor2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            float total1 = (float)(valor * quantidade) + (valor2 * quantidade2); 
           

            Console.WriteLine($"TOTAL A PAGAR PELA PRIMEIRA PEÇA {total1:F2}");




        }
    }
}

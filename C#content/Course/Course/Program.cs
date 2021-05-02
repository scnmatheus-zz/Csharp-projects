using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // TIPOS PRIMITIVOS DE DADOS
            bool completo = false;
            char genero = 'F';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Mária Green";
            object obj1 = "Alex Brown";
            object obj2 = "4.5f";
            
            // SAIDA DESSES DADOS NNA TELA
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
        }
    }
}

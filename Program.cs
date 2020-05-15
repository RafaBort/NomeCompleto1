using System;

namespace NomeCompleto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome...");

            string NOME;
            NOME = Console.ReadLine();

            Console.WriteLine("digite seu sobrenome...");

            string sobrenome;
            sobrenome = Console.ReadLine();

            Console.WriteLine("Obrigada," + NOME + " " + sobrenome + "!!!");

        }
    }
}

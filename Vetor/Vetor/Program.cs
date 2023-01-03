using System;
using Vetor;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] vect = new Product[10];

            Console.WriteLine("Quantos quartos serão alugados? ");
            int numeroQuartos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numeroQuartos; i++)
            {
                Console.WriteLine("Aluguel # " + i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Product(nome, email);
                Console.WriteLine();
            }


            Console.WriteLine("Quartos ocupados: ");
            for (int i = 1; i < vect.Length; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }

        }
    }
}
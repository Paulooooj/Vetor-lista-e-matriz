using System;
using System.Security.Cryptography.X509Certificates;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Número de linhas matriz: ");
            int M = int.Parse(Console.ReadLine());
            Console.Write("Número de colunas matriz: ");
            int N = int.Parse(Console.ReadLine());

            int[,] mat = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                Console.WriteLine("Digite valores linha " + i);
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }



            Console.WriteLine("Digite um número da matriz: ");
            int numeroMatriz = int.Parse(Console.ReadLine());


            for (int i = 0; i < M; i++)
            {

                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] == numeroMatriz)
                    {
                        Console.WriteLine("Position " + i + ", " + j + ":");

                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }

                        if (j < N - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < M - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }

                    }
                    
                }
            }
        }
    }
}
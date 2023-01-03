namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número de Linha da Matriz: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Número de coluna da Matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];
            
            for(int i = 0; i < m; i++)
            {
                Console.WriteLine("Digite a linha " + i + " da matriz.");
                string[] valores = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            Console.Write("Escolha um valor da Matriz: ");
            int valorMatriz = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {               
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine();
                    if (mat[i, j] == valorMatriz)
                    {
                        Console.WriteLine("Position: " + i + ", " + j + ":");
                        
                        if(j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if(j < n - 1)
                        {
                            Console.WriteLine("Rigth: " + mat[i, j + 1]);
                        }
                        if (i != 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if(i < m - 1){
                            Console.WriteLine("Down: " + mat[i + 1, j]);

                        }


                    }
                }
                
            }

        }
    }
}
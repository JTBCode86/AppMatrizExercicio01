using System;

namespace AppMatrizExercicio01
{
    /// <summary>
    /// Exercicio 01 - Matriz
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o tamanho da matriz: ");
            int n = int.Parse(Console.ReadLine());

            double[,] mat = new double[n,n];

            //Percorre a Linha
            for (int i = 0; i < n; i++)
            {
                //Percorre a coluna
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Principais na diagonal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i]);
                Console.Write(", ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Números negativos: " + count);
            Console.ReadLine();
        }
    }
}

using System;

namespace _7___diagonal_negativos {
    class Program {
        static void Main(string[] args) {

            int i, j, cont = 0;

            Console.Write("Qual a ordem da matriz? ");
            int N = int.Parse(Console.ReadLine());
            int[,] mat = new int[N, N];

            for(i = 0; i < N; i++) {
                for(j = 0; j < N; j++) {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());

                }
            }

            Console.WriteLine("DIAGONAL PRINCIPAL:");

            for(i = 0; i < N; i++) {
                for(j = 0; j < N; j++) {
                    if(i == j) {
                        Console.Write(mat[i, j] + " ");
                    }
                    if(mat[i, j] < 0) {
                        cont++;
                    }
                }
            }
            Console.WriteLine();
            Console.Write("QUANTIDADE DE NEGATIVOS = " + cont);
        }
    }
}

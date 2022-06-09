using System;

namespace _6___soma_vetor {
    class Program {
        static void Main(string[] args) {

            int i;
            double soma = 0, media = 0;

            Console.Write("Quantos numeros voce vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];

            for(i = 0; i < N; i++) {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.Write("VALORES = ");

            for(i = 0; i < N; i++) {
                Console.WriteLine(vet[i].ToString("F1"));
                soma = soma + vet[i];
            }
            media = soma / N;
            Console.WriteLine("SOMA = " + soma.ToString("F2"));
            Console.WriteLine("MEDIA = " + media.ToString("F2"));
        }
    }
}

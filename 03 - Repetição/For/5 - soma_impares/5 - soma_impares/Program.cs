using System;

namespace _5___soma_impares {
    class Program {
        static void Main(string[] args) {
            int soma = 0;

            Console.WriteLine("Digite dois numeros:");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if(y > x) {
                soma = x;
                x = y;
                y = soma;
                soma = 0;
            }

            for(y = y++; y < x; y++) {
                if(y % 2 != 0) {
                    soma = soma + y;
                }
               
            }
            Console.WriteLine("SOMA DOS IMPARES = " + soma);
        }
    }
}

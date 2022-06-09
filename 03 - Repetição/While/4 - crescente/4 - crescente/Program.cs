using System;

namespace _4___crescente {
    class Program {
        static void Main(string[] args) {

            int y = 0, x = 1;

            while (x != y) {
                Console.WriteLine("Digite dois numeros: ");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());

                if (x > y) {
                    Console.WriteLine("DECRESCENTE");
                }
                else {
                    if (x < y) {
                        Console.WriteLine("CRESCENTE");
                    }
                }
            }
        }
    }
}

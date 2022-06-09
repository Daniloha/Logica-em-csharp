using System;

namespace _3___menor_de_tres {
    class Program {
        static void Main(string[] args) {

            Console.Write("Primeiro valor: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Terceiro valor: ");
            int z = int.Parse(Console.ReadLine());

            Console.Write("MENOR = ");
            if(x <= y && x <= z) {
                Console.WriteLine(x);
            }
            else {
                if(y <= z && y <= x) {
                    Console.WriteLine(y);
                }
                else {
                    Console.WriteLine(z);
                }
            }
        }
    }
}

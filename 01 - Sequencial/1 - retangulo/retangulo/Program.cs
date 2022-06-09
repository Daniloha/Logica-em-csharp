using System;


namespace retangulo {
    class Program {
        static void Main(string[] args) {

            double a, b, A, P, D;
            Console.Write("Base do retangulo: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Altura do retangulo: ");
            b = double.Parse(Console.ReadLine());

            A = a * b;
            P = (2 * a) + (2 * b);
            D = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            Console.WriteLine("AREA = " + A.ToString("F4"));
            Console.WriteLine("PERIMETRO = " + P.ToString("F4"));
            Console.WriteLine("DIAGONAL = " + D.ToString("F4"));
        }
    }
}

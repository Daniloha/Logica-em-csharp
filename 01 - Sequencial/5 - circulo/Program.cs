using System.Globalization;
// See https://aka.ms/new-console-template for more information

Console.Write("Digite o raio do circulo: ");
double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double Area = constantes.pi * (r * r);

System.Console.WriteLine("AREA = " + Area.ToString("F3", CultureInfo.InvariantCulture));
static class constantes{
public const double pi = 3.14159;
}

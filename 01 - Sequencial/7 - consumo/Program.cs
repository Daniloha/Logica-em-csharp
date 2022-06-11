using System.Globalization;
// See https://aka.ms/new-console-template for more information
Console.Write("Distancia percorrida: ");
double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
System.Console.WriteLine("Combustível gasto: ");
double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double consu = d / c;

System.Console.WriteLine("Consumo médio = " + consu.ToString("F3", CultureInfo.InvariantCulture));


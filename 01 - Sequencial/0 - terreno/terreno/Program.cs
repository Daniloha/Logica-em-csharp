using System.Globalization;

Console.Write("Digite a largura do terreno: ");
double L = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
System.Console.Write("Digite o comprimento do terreno: ");
double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
System.Console.Write("Digite o valor do metro quadrado: ");
double M = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double A  = L * C;

double V = A * M;

System.Console.WriteLine("Area do terreno = " + A.ToString("F2",CultureInfo.InvariantCulture));
System.Console.WriteLine("Valor do terreno = " + V.ToString("F2",CultureInfo.InvariantCulture));
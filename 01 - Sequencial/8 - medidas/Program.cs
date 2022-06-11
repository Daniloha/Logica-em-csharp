using System.Globalization;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Programa para ler três medidas A, B e C "
+"\nEm seguida, calcular e mostrar (imprimir os dados com quatro casas decimais):"
+"\na) a área do quadrado que tem lado A"
+"\nb) a área do triângulo retângulo que base A e altura B"
+"\nc) a área do trapézio que tem bases A e B, e altura C\n");

System.Console.Write("Digite a medida A: ");
double A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
System.Console.Write("Digite a medida B: ");
double B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
System.Console.Write("Digite a medida C: ");
double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double AreaQ = A * A;
double AreaT = (A * B)/2;
double AreaZ = ((A+B)*C)/2;

System.Console.WriteLine("AREA DO QUADRADO = " + AreaQ.ToString("F3", CultureInfo.InvariantCulture));
System.Console.WriteLine("AREA DO TRIANGULO = " + AreaT.ToString("F3",CultureInfo.InvariantCulture));
System.Console.WriteLine("AREA DO TRAPEZIO = " + AreaZ.ToString("F3", CultureInfo.InvariantCulture));
using System.ComponentModel;
using System.Globalization;
// TROCO
Console.Write("Preço  unitário do produto: ");
double P = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.Write("Quantidade comprada: ");
int Q = int.Parse(Console.ReadLine());
System.Console.Write("Valor pago: ");
double V = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

double T = V-(P*Q);

System.Console.WriteLine("TROCO = " + T.ToString("F2",CultureInfo.InvariantCulture));

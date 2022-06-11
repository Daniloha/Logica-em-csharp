using System.Globalization;
// See https://aka.ms/new-console-template for more information
Console.Write("Nome: ");
string Nome = Console.ReadLine();
System.Console.Write("Valor por hora: ");
double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
System.Console.Write("Horas trabalhadas: ");
double horas = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

double pagamento = valor * horas;

System.Console.WriteLine("O pagamento para " + Nome + " é " + pagamento.ToString("F2", CultureInfo.InvariantCulture));


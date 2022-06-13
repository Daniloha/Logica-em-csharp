using System.Globalization;
// See https://aka.ms/new-console-template for more information
Console.Write("Digite a primeira nota: ");
double N1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.Write("Digite a segunda nota: ");
double N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double NF = N1 + N2;

System.Console.WriteLine("NOTA FINAL = " + NF.ToString("F2", CultureInfo.InvariantCulture));

if(NF < 60){
    System.Console.WriteLine("REPROVADO!");

}

using System.Globalization;
// See https://aka.ms/new-console-template for more information
Console.Write("Coeficiente A: ");
double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Coeficiente B: ");
double B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.Write("Coeficiente C: ");
double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double Delta = B*B - 4 * A * C;

double X = (- B + Math.Sqrt(Delta))/(2*A);
double Y = (+ B + Math.Sqrt(Delta))/(2*A);

if(Delta<0){
    System.Console.WriteLine("Esta equação não possui raizes reais.");
}else{
    System.Console.WriteLine("X = " + X.ToString("F4",CultureInfo.InvariantCulture));
    System.Console.WriteLine("Y = " + Y.ToString("F4", CultureInfo.InvariantCulture));
}
// See https://aka.ms/new-console-template for more information
Console.Write("Digite a duração do tempo em segundos: ");
int Seg = int.Parse(Console.ReadLine());

int Res = Seg%60;
int Min = Seg / 60;
Seg = Res;
Res = Min%60;
int Hor = Min/ 60;
Min = Res;

System.Console.WriteLine(Hor+":"+Min+":"+Seg);

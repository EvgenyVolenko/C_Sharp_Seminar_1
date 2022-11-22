Console.Write("Введите число а: ");
string bufa = Console.ReadLine();
int a = int.Parse(bufa);
Console.Write("Введите число b: ");
string bufb = Console.ReadLine();
int b = int.Parse(bufb);
Console.Write("Введите число c: ");
string bufc = Console.ReadLine();
int c = int.Parse(bufc);

int max = a;

if (b > a) max = b;
if (max < c) max = c;

Console.Write("max = ");
Console.WriteLine(max);
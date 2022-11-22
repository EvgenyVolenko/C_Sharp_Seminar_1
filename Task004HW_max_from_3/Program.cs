Console.Write("Введите число а: ");
string bufa = Console.ReadLine();
int a = Convert.ToInt32(bufa);
Console.Write("Введите число b: ");
string bufb = Console.ReadLine();
int b = Convert.ToInt32(bufb);
Console.Write("Введите число c: ");
string bufc = Console.ReadLine();
int c = Convert.ToInt32(bufc);

int max = a;

if (b > a) max = b;
if (max < c) max = c;

Console.Write("max = ");
Console.WriteLine(max);
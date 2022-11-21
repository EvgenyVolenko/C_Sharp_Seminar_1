Console.Write("Введите число а: ");
string bufa = Console.ReadLine();
int a = int.Parse(bufa);
Console.Write("Введите число b: ");
string bufb = Console.ReadLine();
int b = int.Parse(bufb);

int max = a;
int min = b;

if (a > b) 
{
    max = a;
    min = b;
}
if (a < b) 
{
    max = b;
    min = a;
}

Console.Write("max = ");
Console.WriteLine(max);

Console.Write("min = ");
Console.WriteLine(min);
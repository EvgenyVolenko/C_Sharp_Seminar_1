Console.Write("Введите число а: ");
string bufa = Console.ReadLine();
int a = Convert.ToInt32(bufa);
Console.Write("Введите число b: ");
string bufb = Console.ReadLine();
int b = Convert.ToInt32(bufb);

int max = a;
int min = b;

if (a < b) 
{
    max = b;
    min = a;
}

Console.Write("max = ");
Console.WriteLine(max);

Console.Write("min = ");
Console.WriteLine(min);
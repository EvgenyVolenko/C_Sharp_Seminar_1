//Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7, min = 5
//a = 2 b = 10 -> max = 10, min = 2
//a = -9 b = -3 -> max = -3, min = -9

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
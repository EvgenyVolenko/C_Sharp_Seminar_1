//Задача 4: Напишите программу, которая принимает на вход
//три числа и выдает максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

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

if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);
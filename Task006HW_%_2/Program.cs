Console.Write("Введите число: ");
string bufa = Console.ReadLine();
int a = int.Parse(bufa);

if (a % 2 == 0)
{
    Console.Write("Да. Введенное вами число четное!");
}
else Console.Write("Нет. Введенное вами число нечетное!");

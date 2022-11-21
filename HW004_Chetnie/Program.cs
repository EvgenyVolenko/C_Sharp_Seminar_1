Console.Write("Введите число: ");
string bufn = Console.ReadLine();
int n = int.Parse(bufn);

count = 1;

while (count <= n)
{
    if (n % 2 == 0)
    {
        Console.Write("Да. Введенное вами число четное!", n);
        count++;
    }
    else count++;
}

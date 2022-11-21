Console.Write("Введите число: ");
string bufn = Console.ReadLine();
int n = int.Parse(bufn);

int count = 1;

while (count <= n)
{
    if (count % 2 == 0)
    {
        Console.Write(count);
        Console.Write(", ");
        count++;
    }
    else count++;
}

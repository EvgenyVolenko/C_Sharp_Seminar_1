Console.Write("Введите число: ");
string bufn = Console.ReadLine();
int n = Convert.ToInt32(bufn);

int count = 1;

while (count <= n)
{
    if (count % 2 == 0)
    {
        Console.Write(count + ", ");
        count++;
    }
    else count++;
}

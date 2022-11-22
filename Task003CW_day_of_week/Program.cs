//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница

//Понравилась идея реализации в формате строк с проверкой

Console.Write("Введите порядковый номер дня недели от 1 до 7: ");
string nDay = Console.ReadLine();

do 
{
    if (nDay != "1" | nDay != "2" | nDay != "3" | nDay != "4" | nDay != "5" | nDay != "6" | nDay != "7")
    {
        Console.WriteLine("Вы ввели не ту цифру или символ");
    }
} while (false);

if (nDay == "1") Console.Write ("Понедельник");
if (nDay == "2") Console.Write ("Вторник");
if (nDay == "3") Console.Write ("Среда");
if (nDay == "4") Console.Write ("Четверг");
if (nDay == "5") Console.Write ("Пятница");
if (nDay == "6") Console.Write ("Суббота");
if (nDay == "7") Console.Write ("Воскресенье");
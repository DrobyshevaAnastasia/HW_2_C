/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1


int number = ReadInt ("Введите число: ");
int sum = number.ToString().Length;

if ((sum < 3) || (sum > 3))
{
    Console.WriteLine("Введено не трехзначное число");
}
else
{
    Console.WriteLine(InCenter(number));
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int InCenter(int a)
{
    int result = ((a/10) % 10);
    return result;
}


Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6


int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int MakeArray(int a, int b)
{
int result = 0;
    if (b < 3)
    {
        Console.Write("Третьей цифры нет! ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }
        result = (a / c) % 10;
    }
    return result;
}

*/
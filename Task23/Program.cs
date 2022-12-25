using static System.Console;

Write("Введите число: ");
bool numberIsInt = int.TryParse(ReadLine(), out int number);

if (!numberIsInt)
{
    WriteLine("Это не число");
    return;
}

int count = 1;
while(count!=number)
{
    Write($"{Math.Pow(count,3)}, ");
    if (number >0)
    {
        count++;
    }
    else
    {
        count--;
    }
}
WriteLine(Math.Pow(count,3));
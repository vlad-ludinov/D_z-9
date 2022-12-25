using static System.Console;

Write("Введите пятизначное число: ");
bool numberIsInt = int.TryParse(ReadLine(),out int number);
if (!numberIsInt)
{
    WriteLine("Это не число");
    return;
}
if (9999<number && number<100000)
{
    if (number/10000 == number%10 && number/1000%10 == number/10%10)
    {
        WriteLine($"Да, число {number} - палиндром");
    }
    else
    {
        WriteLine($"Нет, число {number} - не палиндром");
    }
}
else
{
    WriteLine("Это не пятизначное число");
}

using static System.Console;

Write("Введите число: ");
bool numberIsInt = int.TryParse(ReadLine(), out int number);

if (!numberIsInt)
{
    WriteLine("Это не число");
    return;
}

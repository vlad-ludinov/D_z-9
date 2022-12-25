using static System.Console;

WriteLine("Введите координаты точки A:");
Write("x: ");
bool axIsInt = int.TryParse(ReadLine(),out int ax);
Write("y: ");
bool ayIsInt = int.TryParse(ReadLine(),out int ay);
Write("z: ");
bool azIsInt = int.TryParse(ReadLine(),out int az);
WriteLine("Введите координаты точки B:");
Write("x: ");
bool bxIsInt = int.TryParse(ReadLine(),out int bx);
Write("y: ");
bool byIsInt = int.TryParse(ReadLine(),out int by);
Write("z: ");
bool bzIsInt = int.TryParse(ReadLine(),out int bz);

if (!AxIsInt||!AyIsInt||!AzIsInt||!BxIsInt||!ByIsInt||!BzIsInt)
{
    WriteLine("Произошла ошибка при вводе координат");
    return;
}
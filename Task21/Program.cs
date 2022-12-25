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

if (!axIsInt||!ayIsInt||!azIsInt||!bxIsInt||!byIsInt||!bzIsInt)
{
    WriteLine("Произошла ошибка при вводе координат");
    return;
}
double ab = Math.Sqrt(Math.Pow(bx-ax, 2) + Math.Pow(by-ay, 2) + Math.Pow(bz-az, 2));

WriteLine($"Расстояние между точками A({ax}, {ay}, {az}) и B({bx}, {by}, {bz}) - {ab:f2}");
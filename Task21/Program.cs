using static System.Console;

WriteLine("Введите координаты точки A:");
Write("x: ");
bool AxIsInt = int.TryParse(ReadLine(),out int number);
Write("y: ");
bool AyIsInt = int.TryParse(ReadLine(),out int number);
Write("z: ");
bool AzIsInt = int.TryParse(ReadLine(),out int number);
WriteLine("Введите координаты точки B:");
Write("x: ");
bool BxIsInt = int.TryParse(ReadLine(),out int number);
Write("y: ");
bool ByIsInt = int.TryParse(ReadLine(),out int number);
Write("z: ");
bool BzIsInt = int.TryParse(ReadLine(),out int number);
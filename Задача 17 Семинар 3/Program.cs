//Программа должна выдавать номер четверти, в зависимости от заданных координат
Console.WriteLine("Введите X");
int X = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y");
int Y = int.Parse(Console.ReadLine());;


if (X == 0| Y == 0)
{
    Console.WriteLine("Координаты не принадлежат конкретной четверти");
}
else if (X > 0 & Y > 0)
{
    Console.WriteLine("Координата принадлежит 2-й четверти");
}
else if (X < 0 & Y > 0)
{
    Console.WriteLine("Координата принадлежит 1-й четверти");
}
else if (X < 0 & Y < 0)
{
    Console.WriteLine("Координата принадлежит 3-й четверти");
}
else if (X > 0 & Y < 0)
{
    Console.WriteLine("Координата принадлежит 4-й четверти");
}
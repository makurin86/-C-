//Программа по номеру четверти определять диапозон ординат
Console.WriteLine("Введите номер четверти");
int chet = int.Parse(Console.ReadLine());

if (chet < 1 || chet > 4)
{
    Console.WriteLine("Номер четверти должен быть от 1 до 4");
}
else if (chet == 1)
{
    Console.WriteLine("Диапозон координат должен находится в пределах Х<0, Y>0");
}
else if (chet == 2)
{
    Console.WriteLine("Диапозон координат должен находится в пределах Х>0, Y>0");
}
else if (chet == 3)
{
    Console.WriteLine("Диапозон координат должен находится в пределах Х<0, Y<0");
}
else if (chet == 4)
{
    Console.WriteLine("Диапозон координат должен находится в пределах Х>0, Y<0");
}
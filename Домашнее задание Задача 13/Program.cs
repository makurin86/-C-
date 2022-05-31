//Задача 13: Напишите программу, которая выводит
//третью цифру заданного числа или сообщает, что третьей
//цифры нет.
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int count = 0;
//Console.WriteLine(num);
if (num < 100)
{
    Console.WriteLine($"В числе {num} третьей цифры нет");
}
else
{
    while (num > 999)
    {
        num = num / 10;
    }

    Console.WriteLine($"Третья цифра: {num % 10}");
}

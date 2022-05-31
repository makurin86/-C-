//Напишите программу, которая принимает на вход
//трёхзначное число и на выходе показывает вторую
//цифру этого числа.
Console.WriteLine("Введите трехзанчное число");
int num = int.Parse(Console.ReadLine());
//Console.WriteLine(num);
if (num < 100)
{
    Console.WriteLine("Введенное число не укладывается в заданные пределы");
}
else
{
    if (num > 999)
    {
        Console.WriteLine("Введенное число не укладывается в заданные пределы");
    }

    else
    {
        Console.WriteLine($"Второе число: {num / 10 % 10}");
    }
}

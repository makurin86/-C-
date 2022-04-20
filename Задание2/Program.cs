//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите А:");
int numA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите B:");
int numB = int.Parse(Console.ReadLine());

if (numA>numB)
{
    Console.Write("Наибольшее число - A, наименьшее - В");
}
else
{
    Console.Write("Наибольшее число B, наименьшее - А");
}
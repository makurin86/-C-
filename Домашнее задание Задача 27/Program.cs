//Задача 27: Напишите программу, которая принимает на
//вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число, мы вычислим сумму цифр, из которых оно состоит");
int num = int.Parse(Console.ReadLine());
int sum = num % 10;
int N = num;
while (num > 0)
{
    num = num / 10;
    sum = num % 10 + sum;
}
Console.WriteLine($"Сумма чисел, из которых состоит число {N} = {sum}");
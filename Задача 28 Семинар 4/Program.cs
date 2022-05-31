//Задача 28: Напишите программу, которая
//принимает на вход число N и выдаёт
//произведение чисел от 1 до N.
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
int num = 1;

for (int i = 1; i <= N; i++)
{

    num *= i;
    // Console.WriteLine(num);
}
Console.WriteLine($"Произведение чисел от 1 до {N} = {num}");
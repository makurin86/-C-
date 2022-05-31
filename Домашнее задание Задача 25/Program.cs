//Задача 25: Напишите цикл, который принимает на вход
//два числа (A и B) и возводит число A в натуральную
//степень B.
Console.WriteLine("Введите число А:");
double A = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число B:");
double B = double.Parse(Console.ReadLine());
if (B <= 0 || (B * 10 % 10) > 0)
{
    Console.WriteLine("Число В должно быть натуральным.");
    Console.WriteLine("Напомним, что натуральными называют целые числа, которые больше нуля. Например, 1, 2, 3 и так далее..");
}

else
{
    int result = (int)Math.Pow(A, B);
    Console.WriteLine($"A в степение В = {result}");
}

//for (int i = 0; i < 3; i++)
//{
//    Console.Write(i);
//}
// Output:
// 012
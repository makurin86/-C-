//Напишите программу, которая принимает на
//вход два числа и проверяет, является ли одно
//число квадратом другого
Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine());
//if (num1*num1==num2) 
if (num2==Math.Pow(num1,2)|num1==Math.Pow(num2,2)) //Math - библиотека математических формул, Pow - возведение в стемпень (основание, степень)
{
    Console.WriteLine($"Одно число является квадратом дгугого числа ");
}
else
{

Console.WriteLine($"Число {num2} не является квадратом числа {num1} и число {num1} не является квадратом числа {num2} ");
}
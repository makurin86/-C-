//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите А:");
int numA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите B:");
int numB = int.Parse(Console.ReadLine());

Console.WriteLine("Введите C:");
int numC = int.Parse(Console.ReadLine());

if (numA > numB)
{
    if (numA > numC)
    {
        Console.Write("Наибольшее число - A");
    }
    else
    {
        Console.Write("Наибольшее число - C");
    }

}
else
{
    if (numB > numC)
    {
        Console.Write("Наибольшее число - B");
    }
    else
    {
        Console.Write("Наибольшее число - C");
    }
}
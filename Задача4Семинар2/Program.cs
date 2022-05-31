//Напишите программу, которая принимает на
//вход число и проверяет, кратно ли оно
//одновременно 7 и 23
Console.WriteLine("Введите число для проверки его кратности 7 и 23:");
int num1 = int.Parse(Console.ReadLine());
//Console.WriteLine(num);

if (num1 % 7 == 0 & num1 % 23 == 0)
{
    Console.WriteLine($"Число {num1} кратно числу 7 и 23");
}
else
{
    Console.WriteLine($"Число {num1} не кратно числу 7 и 23");
}

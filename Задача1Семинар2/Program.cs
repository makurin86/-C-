//Задача: Написать программу, которая выводит максимальное значение из случайных чисел в диапозоне от 10 до 99 и показывает наибольшее значение
int num = new Random().Next(10, 99);
Console.WriteLine(num);

//int Max(int arg1, int arg2)
//{
//    int result = arg1;
//    if(arg2>result) result=arg2;
//    return result;
//}
//void FillArray(int[])
int first = num / 10;
int second = num % 10;

if (first > second)
{
    Console.WriteLine($"Число {first} болтшее");
}
else
{
    Console.WriteLine($"Число {second} болтшее");
}
﻿/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */
Console.WriteLine("Введите размер массива:");
int Size = int.Parse(Console.ReadLine());
int[] array = new int[Size];
Console.WriteLine("Заполните массив:");
int count = 0;
for (int i = 0; i < Size; i++)
{
    array[i] = int.Parse(Console.ReadLine());
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество положительных значений в введенном массиве = {count}");
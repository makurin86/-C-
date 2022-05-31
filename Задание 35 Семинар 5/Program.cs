﻿//Задача 35: Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива, значения которых лежат в
//отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int[] mass = new int[123];
int index = 0;

for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(-100, 100);
    if (mass[i] >= 10 & mass[i] <= 99)
    {
        index = index + 1;
    }
}
Print(mass);
Console.WriteLine($"Количество чисел от 10 до 99 в заданном массиве равно {index}");
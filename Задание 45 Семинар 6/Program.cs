/* Задача 45: Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного
копирования */

Console.WriteLine("Сгенерированный случайным образом массив:");

int[] FillArray(int size, int A, int B)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(A, B);
    }
    return array;
}
void Print(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int[]mass = FillArray(10, 1, 100);

Print(mass);
int[]mass2 = new int[mass.Length];
for (int i = 0; i < mass2.Length; i++)
{
    mass2[i] = mass[i];
}

Console.WriteLine("Скопированный поэлементно массив:");

Print(mass2);
Console.WriteLine("Приравненный массив:");
int[] mass3 = mass;
Print(mass3);


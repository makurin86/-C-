//Задача 34: Задайте массив заполненный случайными
//положительными трёхзначными числами. Напишите
//программу, которая покажет количество чётных чисел в
//массиве.
// Пример: [345, 897, 568, 234] -> 2

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {

        Console.Write(array[i] + " ");

    }
}

int[] mass = new int[new Random().Next(2, 8)];
FillArray(mass);
Console.Write("Массив, заполненный случайными трехзначными, положительными числами:[");
PrintArray(mass);
Console.Write("]");
int count = 0;
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] % 2 == 0)
    {
        //Console.WriteLine(mass[i]);  
        //PrintArray(mass);
        count++;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в масиве: {count}");
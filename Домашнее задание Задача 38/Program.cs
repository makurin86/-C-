//Задача 38: Задайте массив вещественных чисел. Найдите
//разницу между максимальным и минимальным
//элементов массива.
void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100) + new Random().NextDouble();
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {

        Console.Write(Math.Round(array[i], 2) + " ; ");

    }
}

double[] mass = new double[new Random().Next(2, 10)];
FillArray(mass);
Console.WriteLine();
Console.Write("Сгенерированный массив: [");
PrintArray(mass);
Console.WriteLine("]");
double max = mass[0];
double min = mass[0];
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] < min)
    {
        min = mass[i];
    }
    if (mass[i] > max)
    {
        max = mass[i];
    }
}

Console.WriteLine($"Максимальный элемент массива = {Math.Round(max, 2)}, Минимальный элемент массива = {Math.Round(min, 2)}");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {Math.Round(max - min, 2)}");
Console.WriteLine();
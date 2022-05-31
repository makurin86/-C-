//Задача 31: Задайте массив из 12 элементов, заполненный
//случайными числами из промежутка [-9, 9]. Найдите сумму
//отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
//положительных чисел равна 29, сумма отрицательных равна -20.
int[] array = new int[12];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 9);
}
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();
int summNeg = 0;
int summPos = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < 0)
    {
        summNeg += array[i];
    }
    else
    {
        summPos += array[i];
    }
}

Console.WriteLine($"Сумма положительных чисел = {summPos}, сумма отрицательных чисел = {summNeg}");
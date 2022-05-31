//Задача 37: Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний
//и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

void FillArray(int[] array, int A, int B)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(A, B);
    }
}

int[] mass = new int[new Random().Next(3, 10)];
for (int i = 0; i <= mass.Length - 1; i++)
{
    mass[i] = new Random().Next(-10, 10);
}
Print(mass);
int[] result = new int[mass.Length / 2 + mass.Length % 2];

for (int i = 0; i < mass.Length / 2 + mass.Length % 2; i++)

{
    result[i] = mass[i] * mass[mass.Length - 1 - i];
}

Console.WriteLine();
if (mass.Length % 2 > 0)
{
    result[result.Length - 1] = mass[mass.Length / 2];
}

Console.WriteLine($"Длинна первоначального массива = {mass.Length}");
Print(result);

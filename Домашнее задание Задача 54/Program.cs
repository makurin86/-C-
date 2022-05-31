/* Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива */
Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine());
int[,] mass = new int[m, n];
int[,] temp = new int[m, n];

void FillArray(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = new Random().Next(-10, 10);
        }
    }
}
void Print(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write(mass[i, j] + "  ");
        }
        Console.WriteLine();
    }
}
FillArray(mass);
Print(mass);
int max = mass[0, 0];
int count = 0;
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        for (int k = 0; k < mass.GetLength(1) - 1; k++)
        {
            if (mass[i, k] < mass[i, k + 1])
            {
                max = mass[i, k + 1];
                mass[i, k + 1] = mass[i, k];
                mass[i, k] = max;
            }
        }
    }

}


Console.WriteLine();
Print(mass);

/* Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива. */

int m = 6;
int n = 7;
int[,]mass = new int[m,n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i,j] = new Random().Next(0,10);
    }
}
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write(mass[i,j]+ " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int j = 0; j < mass.GetLength(1); j++)
    { 
       Console.Write(mass[mass.GetLength(0)-1,j] + " ");
    }
    Console.WriteLine();
for (int i = 1; i < mass.GetLength(0)-1; i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write(mass[i,j]+ " ");
    }
    Console.WriteLine();
    }
    
    for (int j = 0; j < mass.GetLength(1); j++)
    { 
        Console.Write(mass[0,j]+ " ");
    }
    Console.WriteLine();

/* Задача 47: Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами. */
int m = 4;
int n = 4;
double[,]mass = new double[m,n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i,j] = new Random().Next(-100, 100) + new Random().NextDouble();
        
    }
    
}

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write(Math.Round(mass[i,j],2)+ " ");
    }
    Console.WriteLine();
}

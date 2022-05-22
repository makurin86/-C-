/* Задача 49: Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты. */

int n = 4;
int m = 4;
int [,]mass = new int[m,n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i,j] = new Random().Next(-100,100);
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
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (i%2 == 0 & j%2 == 0)
        {
            Console.Write((mass[i,j]*mass[i,j]) + " ");
        }
        else
        {
        Console.Write(mass[i,j]+ " ");
        }
    }
    Console.WriteLine();
}

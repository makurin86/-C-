/* Задача 48: Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле: Aₙₙ = m+n.
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5 */

int n = 4;
int m = 4;
int[,]mass = new int[m,n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
    mass[i,j] = i+j;
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

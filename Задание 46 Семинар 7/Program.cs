/* Задача 46: Задайте двумерный массив размером m×n,
заполненный случайными целыми числами. */
int m = 3;
int n = 4;
int[,]mass = new int[m,n];

//Console.WriteLine(mass.GetLength(0));
//Console.WriteLine(mass.GetLength(1));


for (int i = 0; i < mass.GetLength(0); i++)
{
 for (int j = 0; j < mass.GetLength(1); j++)
 {
    mass[i,j] = new Random().Next(-100, 100);
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

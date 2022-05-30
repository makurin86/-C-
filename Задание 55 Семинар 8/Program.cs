/* Задача 55: Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя. */

int m = 4;
int n = 4;
int A = 0;
int B = 10;
int save = 0;
int[,]mass = new int[m,n];

void FillArray( int [,]mass)
{
    
    for (int i = 0; i < mass.GetLength(0); i++)
    {
     for (int j = 0; j < mass.GetLength(1); j++)
    {   
        mass[i,j] = new Random().Next(A, B);
    }
   
}}
void Print(int [,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
    {

        Console.Write(mass[i,j] + "  ");
    }
    Console.WriteLine();
}}
FillArray(mass);
Print(mass);
Console.WriteLine();

if (mass.GetLength(0) != mass.GetLength(1))
{
    Console.WriteLine("Заменить строки со столбцами невозможно");
}
else
{
    for (int i=0; i<mass.GetLength(0); i++)
    {
     for (int j=i; j<mass.GetLength(1); j++)
    {
        save = mass[i,j];
        mass[i,j] = mass[j,i];
        mass[j,i] = save;
    }   

    }
    Print(mass);
}

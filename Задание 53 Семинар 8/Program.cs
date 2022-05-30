/* Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива. */

int m = 4;
int n = 4;
int A = 0;
int B = 10;
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
//Console.WriteLine(mass.GetLength(0));
int save = 0;
for (int j=0; j< mass.GetLength(1); j++)
{
    save = mass[0,j];
    mass[0,j] = mass[mass.GetLength(0)-1,j];
     mass[mass.GetLength(0)-1,j] = save;
}
Print(mass);
/* Задача 55: Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя. */
Console.WriteLine("Введите количество строк в массиве");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве");
int n = int.Parse(Console.ReadLine());
int[,]mass = new int[m,n];
int save = 0;
void FillArray (int[,] mass)
{ 
    for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i,j] = new Random().Next(0,10);
    }
}
}
void Print (int[,] mass)
{
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write(mass[i,j]+" ");
    }
    Console.WriteLine();
}
Console.WriteLine();
}
FillArray(mass);
Print(mass);

Console.WriteLine();

if (mass.GetLength(0)!=mass.GetLength(1))
{
    Console.WriteLine("Заменить строки со столбцами не возможно");
}
else
{
    for (int i = 0; i < mass.GetLength(0);i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            save = mass[i,j]; //присваиваем новое значение save
            mass[i,j] = mass[j,i]; //отправляем в массив новые значения, меняя местами адреса строк и столбцов
            mass[j,i] = save;  // обновляем значения массива из save
               
        }
        } 
}
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write(mass[j,i]+" ");
    }
    Console.WriteLine();
}
Console.WriteLine();

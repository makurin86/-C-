/* Задача 50: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

//Условие задачи не совем понял, поэтому решил так: В сгенерированном массиве искал значение, и если находил то выводил номер позиции, если не находил, то сообщал что не найдено.

int m = 5;
int n = 5;
int count = 0;
Console.WriteLine("Введите искомое  в массиве значение");
int find = int.Parse(Console.ReadLine());
Console.WriteLine();
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

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (mass[i,j]==find)
        {
            Console.WriteLine($"Искомое значение {find}, находится в позиции {i}, {j}");
            count++;
        }
        }
    }
if (count==0)
{
    Console.WriteLine($"Искомое значение {find}, в заданном массиве отсутствует");
}

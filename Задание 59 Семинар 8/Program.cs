/* Задача 59: Задайтедвумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
 */
//Заполнение и печать двумерного массива
int m = 4; //Строки
int n = 4; //Столбцы
int A = 0; //Числа массива начинаются от
int B = 10; // Числа массива заканчиваются
int minI = 0;
int minJ = 0;
int[,] mass = new int[m, n];


void FillArray(int[,] mass)
{

    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = new Random().Next(A, B);
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
int min = mass[0, 0];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {

        if (min > mass[i, j])
        {
            min = mass[i, j];
            minJ = j;
            minI = i;

        }
    }

}
Console.WriteLine();
Console.WriteLine(min);
Console.WriteLine(minI + " " + minJ);
int l = 0;
int k = 0;

int[,] mass2 = new int[mass.GetLength(0) - 1, mass.GetLength(1) - 1];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {

        if (i > minI)
        {
            l = i - 1;
        }
        else
        {
            l = i;
        }
        k = j;

        if (j > minJ)
        {
            k = j - 1;
        }
        else
        {
            k = j;
        }

        mass2[l, k] = mass[i, j];


    }

}
Console.WriteLine();
Print(mass2);

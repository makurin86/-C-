/* Задача 58: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц.
 */
 
Console.WriteLine("Введите число строк матрицы А");
int m1 = int.Parse(Console.ReadLine()); //Строки
Console.WriteLine("Введите число строк матрицы А");
int n1 = int.Parse(Console.ReadLine()); //Столбцы
Console.WriteLine("Введите число строк матрицы Б");
int n2 = int.Parse(Console.ReadLine()); //Строки
Console.WriteLine("Введите число строк матрицы Б");
int m2 = int.Parse(Console.ReadLine()); //Столбцы

int A = 0; //Числа массива начинаются от
int B = 10; // Числа массива заканчиваются

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

int[,] mass = new int[m1, n1];
int[,] mass2 = new int[m2, n2];
int[,] mass3 = new int[m1, n2];
FillArray(mass);
FillArray(mass2);
Console.WriteLine("Матрица А:");
Print(mass);
Console.WriteLine();
Console.WriteLine("Матрица Б:");
Print(mass2);
Console.WriteLine();

if (mass.GetLength(1) != mass2.GetLength(0))
{
    Console.WriteLine("Количество столбцов матрицы А должно быть равно количеству строк матрицы Б");
}
else
{
    for (int i = 0; i < mass3.GetLength(0); i++) //Проходит по строкам итогового массива 
    {
        for (int j = 0; j < mass3.GetLength(1); j++)  //Проходит по столбцам итогового массива
        {
            for (int k = 0; k < mass.GetLength(1); k++) //Проходит по стобцам первого массива
            {
                mass3[i,j] += mass[i, k] * mass2[k, j]; //Итоговому массиву присваивается значение суммы произведений массивов по индексу k
            //НЕУЖЕЛИ ЗАРАБОТАЛО!!!!!!!ааааааааааа
            }
        }
    }
    Console.WriteLine("Результат умножения матриц А и Б:");
    Print(mass3);
}
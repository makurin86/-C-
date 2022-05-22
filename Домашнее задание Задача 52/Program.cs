/* Задача 52: Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом
столбце. */

int m = 4;
int n = 4;
double result = 0;
int[,]mass = new int[m,n];
for (int i = 0; i < mass.GetLength(0); i++) //генерируем массив
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i,j] = new Random().Next(0,5);
    }
}

for (int i = 0; i < mass.GetLength(0); i++) // выводим массив
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write(mass[i,j]+ " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int j = 0; j < mass.GetLength(1); j++) // Делаем выборку элементов. (выбираем номера столбцов)
{
    
    
    for (int i = 0; i < mass.GetLength(0); i++)  // Делаем выборку элементов. (выбираем номера строк)
    {
        while(i<=mass.GetLength(0)-1) //увеличиваем результат до тех пор, пока не переберется все строки столбца
        {
            result = mass[i,j]+result;
        i++;
        }
        
    Console.WriteLine(result/n); //находим среднее арифметическое значений в столбце
    result=0; //обнуляем результат, переходим к следующему столбцу
    }
    Console.WriteLine();
}
/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно выводить
массив, добавляя индексы каждого элемента.
 */
Console.WriteLine("Введите число строк (X)");
int X = int.Parse(Console.ReadLine()); //Строки
Console.WriteLine("Введите число столбцов(Y)");
int Y = int.Parse(Console.ReadLine()); //Столбцы
Console.WriteLine("Введите число слоёв (Z)");
int Z = int.Parse(Console.ReadLine()); //Слои
//int A = 0; //Числа массива начинаются от
//int B = 10; // Числа массива заканчиваются
int[,,]mass = new int[X,Y,Z]; 

/* void FillArray( int [,,]mass)
{
    
    for (int x = 0; x < mass.GetLength(0); x++)
    {
     for (int y = 0; y < mass.GetLength(1); y++)
    {   
    
     for (int z = 0; z < mass.GetLength(2); z++)
    {       
        mass[x,y,z] = new Random().Next(A, B);
    }
   
}}} */
void Print(int [,,] mass)
{
    for (int x = 0; x < mass.GetLength(0); x++)
    {
        for (int y = 0; y < mass.GetLength(1); y++)
    {
        
     for (int z = 0; z < mass.GetLength(2); z++)
    {   

        Console.Write($" {mass[x,y,z]} [{x},{y},{z}]");
    }
    Console.WriteLine();
}}}

int count = 0;
for (int x = 0; x < mass.GetLength(0); x++) //Заполнение массива по порядку, начиная с count  (так точно не повторится)
    {
    for (int y = 0; y < mass.GetLength(1); y++)
    {
        for (int z = 0; z < mass.GetLength(2); z++)
        {
            mass[x, y, z] = count;
            count++;
        }}}

Print(mass);


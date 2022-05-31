/* Задача 57: Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных. */

int m = 4; //Строки
int n = 4; //Столбцы
int A = 0; //Числа массива начинаются от
int B = 10; // Числа массива заканчиваются
//Console.WriteLine("Введите искомый элемент");
//int find = int.Parse(Console.ReadLine());
int count = 0;
int[,] mass = new int[m, n];
int[] mass2 = new int[mass.Length]; // массив с уникальными элементами
int[] mass3 = new int[mass.Length]; //количество уникальных элементов
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
/* for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
    {
        if(mass[i,j]==find)
        {
count++;
        }

     
    }
    Console.WriteLine();
    } */
//  Console.WriteLine(count); //количество повторений искомого элемента
int index = 0;
bool exist = false;
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        exist = false;
        for (int l = 0; l < index; l++)
        {
            if (mass2[l] == mass[i, j])
            {
                exist = true;
                mass3[l]++;
                break;
            }
        }
        if (!exist)
        {
            mass2[index] = mass[i, j];
            mass3[index] = 1;
            index++;

        }
    }
}

Console.WriteLine("Уникальные элементы");
for (int i = 0; i < mass2.Length; i++)
{
    Console.Write(mass2[i] + " ");

}
Console.WriteLine();
Console.WriteLine("Количество уникальных значений");

for (int i = 0; i < mass2.Length; i++)
{
    Console.Write(mass3[i] + " ");

}
Console.WriteLine();
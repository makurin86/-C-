/* Задача 62: Заполните спирально массив 4 на 4 */

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] mass = new int[4, 4];

int count = 0;
int i = 0;
int j = 0;

for (j = 0; j < 4; j++) //1
{
    mass[i, j] = count + 1;
    count++;
}

j = 3; 

for (i = i+1; i < 4; i++) //2
{
    mass[i, j] = count + 1;
    count++;
}

i = 3;

for (j = 2; j >= 0; j--) //3
{
    mass[i, j] = count + 1;
    count++;
}

j = 0;

for (i = 2; i > 0; i--)//4
{
    mass[i, j] = count + 1;
    count++;
}

i = 1;

for (j = 1; j < 3; j++)//5
{
    mass[i, j] = count + 1;
    count++;
}

i = 2;

for (j = 2; j > 0; j--)//6
{
    mass[i, j] = count + 1;
    count++;
}

i=i++;


Print(mass);
//Не самое изящное решение, но по другому не работает.


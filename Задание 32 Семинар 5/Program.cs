//Задача 32: Напишите программу замена элементов
//массива: положительные элементы замените на
//соответствующие отрицательные, и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2]

void Print(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int[]mass = new int[4];

for (int i=0; i<mass.Length; i++)
{
    mass[i] = new Random().Next(-100,100);
}
Print(mass);

for (int i = 0; i < mass.Length; i++)
{
    mass[i] = -mass[i];
 }
//Console.WriteLine();
Print(mass);
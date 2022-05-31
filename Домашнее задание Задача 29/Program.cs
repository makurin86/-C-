//Задача 29: Напишите программу, которая задаёт массив
//из 8 элементов и выводит их на экран.
Console.WriteLine("Введите элементы массива");
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {

        Console.Write(array[i] + ", ");

    }
}

int[] mass = new int[8];
FillArray(mass);
Console.Write("[");
PrintArray(mass);
Console.Write("]");
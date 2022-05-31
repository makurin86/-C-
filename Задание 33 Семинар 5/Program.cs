//Задача 33: Задайте массив. Напишите программу, которая
//определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, -3] -> да
Console.WriteLine("Введите искомое число");
int Find = int.Parse(Console.ReadLine());
void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

void FillArray(int[] array, int A, int B)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(A, B);
    }
}

int[] array = new int[5];
FillArray(array, -3, 3);
Print(array);
bool res = false;
for (int i = 0; i < array.Length; i++)
{

    if (array[i] == Find)
    {
        res = true;
    }

}

if (res == true)
{
    Console.WriteLine($"Искомое число {Find} в заданном массиве присутствует");
}
else { Console.WriteLine($"Искомое число {Find} в заданном массиве Отсутствует!!!"); }


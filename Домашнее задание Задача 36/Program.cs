//Задача 36: Задайте одномерный массив, заполненный
//случайными числами. Найдите сумму элементов, стоящих
//на нечётных позициях.

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {

        Console.Write(array[i] + " ");

    }
}

int[] mass = new int[new Random().Next(2, 8)];
FillArray(mass);
Console.Write("Сгенерированный массив: [");
PrintArray(mass);
Console.WriteLine("]");
int result = 0;
Console.Write("Сумма элементов на нечетных позициях: ");
for (int i = 0; i < mass.Length; i++)
{
    if (i % 2 > 0)
    {
        result = mass[i] + result;
        Console.Write($"{mass[i]}");
        if (((mass.Length % 2 == 0) & i < mass.Length - 1) || ((mass.Length % 2 > 0 & i < (mass.Length)))) //Проверка крайнего положения массива
        {
            Console.Write(" + "); //в случае, если положение массива не крайнее, пишем +
        }
    }

}
Console.Write($" = {result}");
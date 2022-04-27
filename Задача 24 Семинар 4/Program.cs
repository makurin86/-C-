//Задача24: Напишите программу, которая принимает на вход число А и выдает сумму чисел от 1 до А
Console.WriteLine("Введите число А");

int A = int.Parse(Console.ReadLine());
int sum = 0;
for (int index=1; index <=A; index++)
{
    sum +=index;
 //   Console.WriteLine(index+" ");
}
//Console.WriteLine(A);
Console.WriteLine($"Сумма чисел от 1 до {A} равна {sum}");
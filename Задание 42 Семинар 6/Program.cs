// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10

Console.WriteLine("Введите десятичное число ");
int a = int.Parse(Console.ReadLine());
int count = 0;
int save = a;
while (a > 0)
{
    a = a / 2;
    Console.WriteLine("a=" + a);
    count++;
}
Console.WriteLine(count);
int[] mass = new int[count];
int i = mass.Length - 1;
a = save;
Console.WriteLine("a=" + a);
while (a > 0)
{
    mass[i] = (a % 2);
    a = a / 2;
    i--;

}
for (i = 0; i < mass.Length; i++)
{
    Console.Write(mass[i] + " ");
}
Console.WriteLine();
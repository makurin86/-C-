// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10

Console.WriteLine("Введите десятичное число ");
int a = int.Parse(Console.ReadLine());

string j = string.Empty;
while (a>0)
{
    j = a%2+j;
    a=a/2;
    
}

Console.WriteLine(j);
// Напишите программ , которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N
Console.WriteLine("Введите чило N");
int N = int.Parse(Console.ReadLine());
int count = 1;

while (count < N)
{
    Console.WriteLine(Math.Pow(count, 3));
    count++;
}
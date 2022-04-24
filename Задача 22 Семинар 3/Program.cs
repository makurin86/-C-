// Напишите программ , которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N
Console.WriteLine("Введите чило N");
int N = int.Parse(Console.ReadLine());
int count = 1;

while (count<N)
{
    Console.WriteLine(Math.Pow(count,2));
    count++;
}
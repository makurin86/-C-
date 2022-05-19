/* Задача 44: Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */
int a1 = 0;
int a2 = 1;
int sum = 0;

Console.WriteLine("Введите число N:");
int N = int.Parse(Console.ReadLine());
    Console.Write(a1 + " " + a2+ " ");
for (int i = 0; i < N; i++)
{
    sum = a1+a2;
    a1=a2;
    a2=sum;
    Console.Write(sum + " ");
}
/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

int Rec(int A, int B)
{
    Console.WriteLine($"{A}^{B}");
    if (B == 0)
    {
        return 1;
    }
    else
    {
        return A * Rec(A, B - 1);

    }
}
int save = Rec(3, 5);
Console.WriteLine(save);
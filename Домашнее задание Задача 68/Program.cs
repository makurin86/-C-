/* адача 68: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29 */

Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();


int Rec(int m, int n)
{
                if (m == 0) 
                return n + 1;

                if (m != 0 && n == 0) 
                return Rec(m - 1, 1);

                if (m > 0 && n > 0) 
                return Rec(m - 1, Rec(m, n - 1));
                return Rec(m,n);
            }
int save = Rec(m,n);
Console.WriteLine(save);
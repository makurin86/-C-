/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
Console.WriteLine("Введите число M");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
Console.WriteLine();
int save = 0;
if (N>M)
{
int Rec(int M, int N)
{
    if(M==N+1)
       return 0;
       return M + Rec(M+1, N);
       
}
save = Rec(M,N);
}
else
{
int Rec(int N, int M)
{
    if(N==M+1)
       return 0;
       return N + Rec(N+1, M);
       
}
save = Rec(N,M);
}

Console.WriteLine($"Сумма элементов от M до N = {save}");
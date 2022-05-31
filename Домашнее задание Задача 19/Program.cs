//Программа принимает на вход пятизначное число и проверяет является ли оно палиндромом

Console.WriteLine("Введите пятизначное число");
int N = int.Parse(Console.ReadLine());

if (N > 10000 & N < 99999)
{
    int N1 = N % 10;
    int N2 = N / 10 % 10;
    int N3 = N / 100 % 10;
    int N4 = N / 1000 % 10;
    int N5 = N / 10000 % 10;
    //Console.WriteLine(N1);
    //Console.WriteLine(N2);
    //Console.WriteLine(N3);
    //Console.WriteLine(N4);
    //Console.WriteLine(N5);
    if (N1 == N5 || N2 == N4)
    {
        Console.WriteLine($"Число {N} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {N} не является палиндромом");
    }
}
else
{
    Console.WriteLine("Число должно быть пятизначное!");
}

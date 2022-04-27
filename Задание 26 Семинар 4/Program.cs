//Программа принимает на вход число, и выдает каличество цифр в нем
Console.WriteLine("Введите число А для вычисления количества цифр в нем");
int A = int.Parse(Console.ReadLine());
int count = 0;

while (A>0)
{
    A=A/10;
    count++;
}
Console.WriteLine($"Количество цифр в числе A = {count}");
    //Console.WriteLine(A);
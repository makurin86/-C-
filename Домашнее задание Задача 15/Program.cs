//Напишите программу, которая принимает на
//вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.
Console.WriteLine("Введите цифру, обозначающую день недели ");
int num = int.Parse(Console.ReadLine());
if (num==1){string day = "Понедельник";
Console.WriteLine($"{day} - будний день");}
if (num==2){string day = "Вторник";
Console.WriteLine($"{day} - будний день");}
if (num==3){string day = "Среда";
Console.WriteLine($"{day} - будний день");}
if (num==4){string day = "Четверг";
Console.WriteLine($"{day} - будний день");}
if (num==5){string day = "Пятница";
Console.WriteLine($"{day} - будний день");}
if (num==6){string day = "Суббота";
Console.WriteLine($"{day} - выходной день");}
if (num==7){string day = "Воскресенье";
Console.WriteLine($"{day} - выходной день");}

if (num>7 | num<1)
{
    Console.WriteLine("Цифра должна быть от 1 до 7");
}
//else{
//    if (num==6 | num==7)
//    {
//        if (num==6){string day = "Суббота";
//            {Console.WriteLine($"День {num} - выходной");}
//if (num==7){string day = "Воскресенье";}
//        Console.WriteLine($"День {num} - выходной");
//    }
//    else{
//        Console.WriteLine($"День {num} - будний");
//    }
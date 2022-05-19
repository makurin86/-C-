/* Задача 43. Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями y = k1 *
x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 =
9 -> (-0,5; 5,5) */
int size = 1000;
Console.WriteLine("Введите коодинаты прямой №1 y=k1*x + b1");
Console.Write("b1 = ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("k1 = ");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите коодинаты прямой №2  y=k2*x + b2");
Console.Write("b2 = ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("k2 = ");
double k2 = double.Parse(Console.ReadLine());

      if ((k1 - k2) == 0 & (b1-b2)==0)
        {
            Console.WriteLine("Прямые совпадают");
        } 
        else
        {
        if ((k1 - k2) == 0)
        {
            Console.WriteLine("Прямые параллельны");
        } 
        

 else{
 double x =(b2-b1)/(k1-k2);
  double y1 = k1*x+b1;
 double y2 = k2*x+b2;
    Console.WriteLine($"Координаты точки пересечения прямых линий: x={Math.Round(x,2)}, y1={Math.Round(y1,2)}, Проверка: y2={Math.Round(y2,2) } ");
           
 }
        }
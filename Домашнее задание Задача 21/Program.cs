//Программа ищет расстояние между точками по координатам (в 3D)

Console.WriteLine("Введите координаты первой точки (х1)");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки (y1)");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки (z1)");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки (х2)");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки (y2)");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты третей точки (z2)");
int z2 = int.Parse(Console.ReadLine());


int kvadr = (int)Math.Pow(x1-x2,2) + (int)Math.Pow(y1-y2,2)+ (int)Math.Pow(z1-z2,2);
double lenth = Math.Sqrt(kvadr);

Console.WriteLine($"Длина отрезка между точками {lenth}");

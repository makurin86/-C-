//Программа ищет расстояние между точками по координатам (в 3D)

Console.WriteLine("Введите координаты первой точки (х)");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки (y)");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты третей точки (z)");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки (х)");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки (y)");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты третей точки (z)");
int z2 = int.Parse(Console.ReadLine());


int kvadr = (int)Math.Pow(x1-x2,2) + (int)Math.Pow(y1-y2,2)+ (int)Math.Pow(z1-z2,2);
double dlinna = Math.Sqrt(kvadr);

Console.WriteLine($"Длина отрезка между точками {dlinna}");

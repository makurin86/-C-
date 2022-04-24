//Программа ищет расстояние между точками по координатам

Console.WriteLine("Введите координаты первой точки (х)");
int x1 = int.Parse(Console.ReadLine());


Console.WriteLine("Введите координаты первой точки (y)");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки (х)");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки (y)");
int y2 = int.Parse(Console.ReadLine());

int kvadr = (int)Math.Pow(x1-x2,2)+ (int)Math.Pow(y1-y2,2);
double dlinna = Math.Sqrt(kvadr);

Console.WriteLine($"Длина отрезка между точками {dlinna}");

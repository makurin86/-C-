/* Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов. */
Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine());
int[,]mass = new int[m,n];
int[,]temp = new int[m,n];

void FillArray (int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i,j] = new Random().Next(-10, 10);
        }
    }
}
void Print (int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write (mass[i,j]+ "  ");
        }
        Console.WriteLine();
    }
}
FillArray(mass);
Print(mass);

int min = 0;
int sum = 0;
int save=0;
int stroka = 0;
   for (int i = 0; i < mass.GetLength(0); i++)
   {
    sum=0;
      for (int j = 0; j < mass.GetLength(1); j++)
      {
               sum = sum+mass[i,j];
               //Console.Write(sum+"  ");
               save = sum;
                    
        }

        if (save<min)
                    {
                       min=save;
                       stroka = i+1;
                    }
        
        
    
       }     

    Console.WriteLine();
    Console.WriteLine($"Минимальная сумма значений ({min}) находится в строке №{stroka}");
    
    

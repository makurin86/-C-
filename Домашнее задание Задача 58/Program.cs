/* Задача 58: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц. */
Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine());
int[,]mass = new int[m,n];
int[,]mass2 = new int[m,n];
int[,]temp = new int[m,n];
int[,]temp2 = new int[m,n];
int[,]result = new int[m,n];

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
Console.WriteLine();
FillArray(mass2);
Print(mass2);
/* 
for (int i = 0; i < mass.GetLength(0); i++)
   {
   for (int j = 0; j < mass.GetLength(1); j++)
   {
        for (int k = 0; k < mass2.GetLength(0); k++)
   {
   for (int l = 0; l < mass2.GetLength(1); l++)
   {
            temp[j,i]=mass[i,j]*mass2[i,j];
   }}}}
//      for (int l = 0; l < mass2.GetLength(1); l++)
   {
//Console.Write(mass[i,j]+ " "+ mass2[j,i]+ " ");
    //   temp2[l,k]=mass[k,l]*mass2[l,k];
       //temp[l,j]=mass[l,j]+mass2[l,j];
       } */
       
          {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    for (int k = 0; k < n; k++)
                        result[i, j] += mass[i, k]*mass2[k, j];

            return result;
        }


/* 
            for (int i = 0; i < mass2.GetLength(1); i++)
            {
                for (int j = 0; j < mass2.GetLength(0); j++)
                {
                    temp[i, j] = 0;
                    for (int k = 0; k < mass2.GetLength(0); k++)
                    {
                        Console.Write(mass[i, k]+ " ");
                        Console.WriteLine();
                        Console.Write(mass[k, j]+ " ");
                        Console.WriteLine();
                        temp[i, j] += mass[i, k] * mass2[k, j];
                    }
                }
            }
            
       Console.WriteLine(); */
Print(temp);
      Console.WriteLine();
Print(temp2);
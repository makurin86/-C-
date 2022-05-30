/* Рекурсия */
int Rec(int n)
{
    if(n==0)
       return 1;
       //Console.WriteLine(n*n);
       return Rec(n-1)*2;
    
}
int save = Rec(10);
Console.WriteLine(save);
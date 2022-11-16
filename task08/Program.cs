//На входе число N, на выходе ряд из четных чисел от 1 до N

Console.Clear();
Console.WriteLine ("Введите число -  ");
int N = Convert.ToInt32( Console.ReadLine());
int A = 1;

 while (A <= N)
{
    if ( A%2 ==0) 

    {
       Console.Write( A  );
    }
    else
    {
       Console.WriteLine(  );
    }
   A++;
}
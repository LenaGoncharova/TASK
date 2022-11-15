// на вход принимает два числа, на выход выдает какое из них большее и меньшее.
Console.Clear();
Console.WriteLine("Введите первое число -  ");
int A = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите второе  число -  ");
int B = Convert.ToInt32(Console.ReadLine()); 


 int max = 0;
 int min = 0;

if ( A >  B)
{
   max = A;
   min = B;
}
else
{
   max = B;
   min = A;
}

Console.Write("максимальное число - ");
Console.WriteLine( max);

Console.Write("минимальное число -");
Console.WriteLine(min);
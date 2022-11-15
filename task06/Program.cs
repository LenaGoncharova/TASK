// на входе число, на выходе - его четность или нечетность.
Console.Clear();
Console.WriteLine(" Введите число - ");
int A = Convert.ToInt32(Console.ReadLine());
int res = A%2;
if(res==0)
{
    Console.WriteLine($"{A}- четное число ");
}
else
{
   Console.WriteLine($"{A}- нечетное число "); 
}
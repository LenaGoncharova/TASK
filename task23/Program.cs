using static System.Console;

Write("Введите целое число:- ");
int n = Convert.ToInt32(ReadLine());

int CubNun(int a)
{
int resalt = Convert.ToInt32(Math.Pow(a,3));
  return resalt;    
} 
int res = CubNun( n);
if (n>0)
WriteLine($" {n}->{res,4}");
else 
{
    WriteLine("!");
}

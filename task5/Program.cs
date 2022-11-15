// напишите программу, в которой на входе натуральное число N,а на выходе ряд чисел от -N  до N. 
Console.Clear();
Console.WriteLine("введите натуральное число - ");
int N = Convert.ToInt32( Console.ReadLine());
int A =-N;
while(A<=N)
{
  Console.WriteLine(A);
  A++;
}

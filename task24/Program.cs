// Напишите программу, которая принимает на вход
//  число A и выдает сумму чисел от 1 до A; 7->28; 4->10
Console.Clear();
Console.WriteLine("введите число ");
int n =Convert.ToInt32(Console.ReadLine());

 int Summ (int a)
 {
    int res=0;     
   for ( int i=1; i<=a;i++)
   {
        res+=i;  //   res=res+i;
   }
    return res;
 }
  if (n>0)
  {
   int summ = Summ (n);
  Console.WriteLine($"сумма чисел от  1  до {n} = {summ}");

  }
else
  Console.WriteLine(" ввели не натуральное число");
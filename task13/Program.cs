// Напишите программу, которая выводит третью цифру заданного числа
//  или сообщает, что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

Console.Clear();
Console.Write ("введите любое целое число");
int num= Math.Abs(Convert.ToInt32(Console.ReadLine()));
 
 int Therd ( int number)
 {
   if (number>=100 && number<1000) return number%10;
   if (number>=1000 && number<10000) return number%100;
   if (number>=10000 && number<100000) return number%1000;
   if (number <99 ) return 0;
 }
 
int therdNumber=Therd( num) ;
Console.WriteLine ( therdNumber);
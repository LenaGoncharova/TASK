// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//  452 -> 11

// 82 -> 10,  82 -> 10 ,9012 -> 12
Console.Clear();
Console.Write("Введите первое число:   ");
int number = Convert.ToInt32(Console.ReadLine());

int SummNumber(int num)
{
    int summ = 0;
    while (num>=0)
     {

      num= num/10;  
      
     } 
     return  summ+(num%10); 
}

int summNumber = SummNumber( number);
Console.Write ($"{summNumber}");



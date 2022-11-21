
        
        // Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
//  Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 78 -> третьей цифры нет
// 645 -> 5
// 32679 -> 6
Console.Clear();

 Console.Write("введите целое число- ");
 int number=Convert.ToInt32(Console.ReadLine());
 
if  (number<1000 && number>99)
        {

            Console.WriteLine($"{number}-> {number%10}");
        } 
        
        else
        {
            Console.WriteLine(" третьего числа нет");
        }
 
        if(number>1000) 
        {
            while (number<=100)
            number=number/10;
        }
        
        


        
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
        
        Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("(этот день выходной) -> да");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("это вообще не день недели");
  }
  else Console.WriteLine("(этот день не выходной) -> нет");
}

CheckingTheDayOfTheWeek(dayNumber);


Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("третья цифра -> " + anyNumberText[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}
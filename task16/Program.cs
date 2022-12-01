// напишите программу,которая принимает на вход два числа и проверяет,
// , является ли одно число квадратом другого
 using static System. Console;
Console.Clear();
  WriteLine(" введие первое число:  ");
 int num1= int.Parse (Console.ReadLine());
 WriteLine(" введие второе  число:  ");
   int num2= int.Parse (Console.ReadLine());
  bool QvartDigit( int digit1, int digit2 )
  {
    return  digit1*digit1 == digit2||  digit2*digit2==digit1;

  }
 bool resalt= QvartDigit( num1, num2 );
 WriteLine ( resalt ? "Да" : " Нет");
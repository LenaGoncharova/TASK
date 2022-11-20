// напишите программу, которая будет принимать на вход два числа в выводить, является ли
//  первое число кратным второму.Если первое число не кратно второму, то программа  выводит остаток от деления.
Console.Clear();
int Multiplicity(int num1, int num2)
{

int res = num1 % num2;
return res;

}


Console.WriteLine("Введите первое число ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int numberB = Convert.ToInt32(Console.ReadLine());


int result = Multiplicity(numberA, numberB);
if (result == 0) Console.WriteLine($"Число {numberA} кратно числу {numberB}");
else Console.WriteLine( $"Не кратно, остаток {result}");
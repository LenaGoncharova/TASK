// напишите программу, которая принимает на вход число  и проверяет
// кратно ли оно одновременно 7ии 23.
Console.Clear();

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool MultiplicityTwoDigits (int num)
{
return num % 7 == 0 && num % 23 == 0;
}

bool result = MultiplicityTwoDigits(number);
Console.WriteLine(result ? "Да" : "Нет");
//   Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом второго
Console.Clear();
Console.WriteLine("введите число 1   ");
int number1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 2   ");
int number2 = Convert.ToInt32(Console.ReadLine());
int C = number2*number2;

if (C== number1)
{
    Console.WriteLine($"{number1} -есть квадрат {number2}");
}

else  Console.WriteLine($"{number1} -не квадрат {number2}");


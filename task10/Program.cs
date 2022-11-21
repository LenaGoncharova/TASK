// Напишите программу, которая принимает на вход трёхзначное число и
//  на выходе показывает вторую цифру этого числа.
//  Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

//int number = new Random(). Next(100, 1000);
// Console.WriteLine( number);
// int res = ((number/10)%10);
// Console.WriteLine($"{number}->{res}");

int SecondDigit( int num)
{
    int res=(num/10)%10;
    return res ;
}
int number  = new Random(). Next(100, 1000);
int resalt=SecondDigit(number);

Console.WriteLine($"{number}->{resalt}");
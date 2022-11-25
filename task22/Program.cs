// Напишите программу, которая принимает на вход число (N) и выдает
//  таблицу квадратов от 1 до Т
Console.Clear();
Console.Write("введите число N: ");
int count = Convert.ToInt32(Console.ReadLine());
int a = 1;
int SquareNumber(int x)
{
    int y=1;
    while (x <= y)
    {
       int res = x * x;
    }
         x++;
    return res;
}

int squareNumbe = SquareNumber(a, count);
Console.Write(squareNumbe);


Console.WriteLine("Введите натуральное число ->");
int number =Convert.ToInt32(Console.ReadLine());


void Quadre(int num)
{
int num1 = 1;
while (num1 <= num)
{
int square = num1 * num1;
 Console.WriteLine($"{num1, 4} {square, 4}");     цифра <4>- показывает количество отступов для выравния таблиц!!
num1 ++;
}
}
if (number > 0)
Quadre(number);
else Console.WriteLine("Число не является натуральным");
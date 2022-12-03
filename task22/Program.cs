// Напишите программу, которая принимает на вход число (N) и выдает
//  таблицу квадратов от 1 до Т
Console.Clear();
Console.Write("введите число N: ");
int tab = Convert.ToInt32(Console.ReadLine());

void SquareNumber(int x)
{
    int count = 1;
    while (count <= x)
    {
        int res = count * count;
        Console.WriteLine($"{count} {res}");
        count++;
    }

}
if (tab > 0)
    SquareNumber(tab);
else Console.WriteLine("Число не является натуральным");


Console.WriteLine("Введите натуральное число ->");
int number = Convert.ToInt32(Console.ReadLine());


void Quadre(int num)
{
    int num1 = 1;
    while (num1 <= num)
    {
        int square = num1 * num1;
        Console.WriteLine($"{num1,4} {square,4}"); цифра < 4 > -показывает количество отступов для выравния таблиц!!
    num1++;
    }
}
if (number > 0)
    Quadre(number);
else Console.WriteLine("Число не является натуральным");
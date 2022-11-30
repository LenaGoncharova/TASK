// Напишите программу, которая принимает на вход число
// и выдает количество цифры в числе :435->3/
Console.Clear();
Console.WriteLine("введите целое число ");
int num = Convert.ToInt32(Console.ReadLine());

int NumberDigital(int x)
{
    int res = 0;
    while (x != 0)                 // while (x!=0)  -означает x не равен 0    
    {
        x = x / 10;
        res = res + 1;
    }
    return res == 0 ? 1 : res;

}

int numberDigital = NumberDigital(num);
Console.WriteLine($"количество цифр в числе {num}->{numberDigital}");



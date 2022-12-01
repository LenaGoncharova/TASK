// напишите программу, которая принимает
// на вход число N  и выдает произведение чисел от 1 до N

Console.Clear();
Console.WriteLine("Введите число:    ");
int n = Convert.ToInt32(Console.ReadLine());

int ProductNumbers(int num)
{
    int res = 1;
    for (int i = 1; i <= num; i++)
    {
         res = res * i;
    }
    return res;
}
int productNumbers = ProductNumbers(n);
Console.WriteLine($" произведение чисел от 1 до {n} = {productNumbers}");
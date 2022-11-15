// Программа, которая на вход принимае трехзначное число, а на выходе дает последнюю цифру этого числа 
Console.Clear();
Console.WriteLine("Введите трехзначное число  - ");
int count = Convert.ToInt32(Console.ReadLine());
int F = count%10;
Console.WriteLine (F);
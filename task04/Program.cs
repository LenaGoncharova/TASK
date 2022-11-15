// на входе - три числа, на выхое - максимальное из них.
Console.Clear();
Console.WriteLine ("Введите число A - ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число B - ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число C - ");
int C = Convert.ToInt32(Console.ReadLine());

int maximum =  A;

if (maximum <B) maximum = B;
if (maximum <C) maximum = C;
{
    Console.Write ("максимальное число -");
    Console.Write ( maximum );
}
//Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве

// А(3,6);В(2,1)->5,09
// А(7,-5);В(1,-1)->7,21

Console.Clear();

Console.Write("Введите  координаты точки Ax ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите  координаты точки Ay ");
int y1 = int.Parse(Console.ReadLine());

Console.Write("Введите  координаты точки Bx: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите  координаты точки By: ");
int y2 = int.Parse(Console.ReadLine());

double Distance(int ax, int ay, int bx, int by)
{
    return Math.Sqrt((bx - ax)*(bx - ax) + (by - ay)*(by - ay) );

}

double distance =Math.Round (Distance(x1, y1, x2, y2),2,MidpointRounding.ToZero);
Console.WriteLine(distance);






// double res = Math.Sqrt(a * b);
// double res1 = Math.Round(res, 2, MidpointRounding.ToZero);
// Console.WriteLine(res1);

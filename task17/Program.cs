// Напишите программу, которая принимает на вход
// координаты точки(X и Y),причем X и Y не равны нулю 
//  и выдает номер четверти плоскости, в которой находится эта точка
// Console.Clear();
// Console.Write("Введите координату X: ");
// int x= Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y: ");
// int y= Convert.ToInt32(Console.ReadLine());

// if(x>0 && y>0) Console.WriteLine("это четверть -1 ");
// else if (x<0 && y>0) Console.WriteLine("это четверть - 2 ");
// else if (x<0 && y<0) Console.WriteLine("это четверть - 3 ");
// else if (x>0 && y<0) Console.WriteLine("это четверть - 4 ");

// методом функции
int Quarter(int xa, int ya)
{ 
 if(xa>0 && ya>0) return 1;
 if (xa<0 && ya>0) return 2;
 if (xa<0 && ya<0) return 3;
 if (xa>0 && ya<0) return 4;
 return 0;
}

Console.Write(" X: ");
int x= Convert.ToInt32(Console.ReadLine());
Console.Write(" Y: ");
int y= Convert.ToInt32(Console.ReadLine());




int quarter = Quarter(x, y);
string result = quarter > 0
? $"Указанные координаты соответствуют четверти -> {quarter}"
: "Введены некорректны координаты";
// string result = quarter > 0
// ? $"Указанные координаты соответствуют четверти -> {quarter}"  ТЕРНАРНЫ МЕТОД ВЫВОДА ДАННЫХ  !!!
// : "Введены некорректны координаты";

Console.WriteLine(result);


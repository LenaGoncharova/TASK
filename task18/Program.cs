// Напишите программу, которая по заданному номеру четверти, показыает диапазон возможных
// кординат точек в этой четверти (x и y)
Console.Clear();
Console.Write("введите номер четверти: ");
int res= int.Parse(Console.ReadLine());

string Quarter( int  result)
{
  if (result == 1) return "x>0 и y>0" ; 
  if (result == 2 )return "x<0 и y>0 "; 
  if (result == 3 )return"x<0 и y<0 "; 
  if (result == 4 )return "x>0 и y<0" ; 
  return  "ввели неправильное число";
}

string number= Quarter( res);
Console.WriteLine(number );
Console.WriteLine (Quarter( res));
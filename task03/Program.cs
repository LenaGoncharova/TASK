// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
Console.Clear();
Console.Write("введите число дня недели  ");
int N = Convert.ToInt32 (Console.ReadLine());
if(N ==1) Console.Write("- это понедельник ");
else if(N ==2) Console.WriteLine(" -это вторник  ");
else if(N ==3) Console.WriteLine("- это среда   ");
else if(N ==4) Console.WriteLine("- это четверг   ");
else if(N ==5) Console.WriteLine("- это пятница  ");
else if(N ==6) Console.WriteLine(" -это суббота   ");
else if(N ==7) Console.WriteLine("- воскресенье!  ");
else Console.WriteLine(" Вы ошиблись   ");

// Console.WriteLine("Введите натуральное число ->");
// int number = Convert.ToInt32(Console.ReadLine());


// void Quadre(int num)
// {
//     int num1 = 1;
//     while (num1 <= num)
//     {
//         int square = num1 * num1;
//         Console.WriteLine($"{num1,4} {square,4}");
//         num1++;
//     }
// }
// if (number > 0)
//     Quadre(number);
// else Console.Write("Число не является натуральным");


// int[] array = new int[8];
// void FillArray (int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0, 100);
//     }
// }



int[] array = new int[12];
void NewArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 15);
    }

}

void PrintArr (int[] arr)
{
    for(int i=0;i<arr.Length;i++)
    {
        Console.Write( $" {arr[i]},");

    }

}

NewArr(array);
PrintArr(array);
    
 int[]inf=new int[12] ; 
 void FillAr(int[]coll)
 {
    for (int i = 0; i <coll.Length; i++)

    {
        coll[i]=new Random().Next(-7,19);
        
    }

 }

 void PrintAr(int[] collect)
 {
   for (int i = 0; i <collect. Length; i++)
   {
     Console.WriteLine($"{collect[i]} ");
   }
}
 FillAr( inf);
 PrintAr(inf);


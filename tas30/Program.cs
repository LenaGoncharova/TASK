// Напишите программу, которая выводит массив
// из 8 элементов, заполенный нулями и единицами
//  в случайном порядке {1,1,0,1,1,0,0,1}
Console.Clear();
int [] array= new int [8];

void  NewArr(int[]arr)
{
  Random rnd = new Random();
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i]=rnd.Next(0, 2);
  }
}

void  PrintArr(int[]arr)
{
    Console.Write("[");
  for (int i = 0; i < arr. Length; i++)
  {
    Console.Write($"{arr[i]} ");
  }
  Console.Write("]");
}

NewArr (array);
PrintArr(array);
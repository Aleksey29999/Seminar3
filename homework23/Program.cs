// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// // 3 -> 1, 8, 27
// // 5 -> 1, 8, 27, 64, 125

// int Readnumbers(string message)
//  {
//      Console.WriteLine(message);
//      int value = Convert.ToInt32(Console.ReadLine()); 
//      return value;
//  }
// int Number = Readnumbers("Введите число =");

// int NumberPow3(Index)
// {return Math.Pow(index,3)
// }
// for (int index = 1; index <= Number; index++)
// {
//    Console.Write((Math.Pow(index,3))+",");
// }


int Readnumbers(string message)
 {
     Console.WriteLine(message);
     int value = Convert.ToInt32(Console.ReadLine()); 
     return value;
 }
int Pow3(int a, int b)
{
  int Pow3 = Convert.ToInt32(Math.Pow(a , 3));
  return Pow3;
}
int Number = Readnumbers("Введите число =");
for (int index = 1; index <= Number; index++)
{
 int q = Pow3(index,3);
 Console.Write(q + ",");
}
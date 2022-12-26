// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Readfivenumbers(string message)
 {
     Console.WriteLine(message);
     int value = Convert.ToInt32(Console.ReadLine()); 
     return value;
 }

int Number = Readfivenumbers("Введите пятизначное число =");
int N = Number.ToString().Length;
if (N == 5) 
{
if  (Number/10000 == Number % 10 && Number %10000 / 1000 == Number % 100/10)
{
     Console.WriteLine("да");   
}
else
{
   Console.WriteLine("нет"); 
}
 }
 else 
 {
    Console.WriteLine("Это не пятизначное число");
 }

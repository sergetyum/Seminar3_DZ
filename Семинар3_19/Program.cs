// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число:");
int number = int.Parse (Console.ReadLine()); 
if (number >= 0)
{
   if (number >= 10000 && number < 100000)
   {
      string numbertext = Convert.ToString(number);
      if (numbertext [0] == numbertext [4] || numbertext [1] == numbertext [3])
      {
      Console.Write("Число является палиндромом.");
      }
      else
      {
      Console.Write("Число не является палиндромом.");
      }
   }
   else
   {
   Console.Write("Число не является пятизначным."); 
   }
}
else
{
Console.Write("Число отрицательное.");
}
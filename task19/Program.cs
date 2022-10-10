// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
Console.Write("Введите 5и значное число:");

int a = Convert.ToInt32(Console.ReadLine());
int b = 0;
int c = 0;

if (a < 10000 || a > 100000){
 Console.WriteLine("число введено неверно");
}
else {
  b = a % 10;
  c = (a % 100)/10;
}

if (a / 10000 == b && (a / 1000)%10==c)
 Console.WriteLine("да");
 else
  Console.WriteLine("нет");
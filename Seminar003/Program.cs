// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.Clear();
Console.Write("Введите число от 1 до 7: ");
int numberDayOfWeek = int.Parse(Console.ReadLine()!);
if (numberDayOfWeek < 1 || numberDayOfWeek > 7)
{
  Console.WriteLine("неверное число введите от 1 до 7");
  return;
}

if (numberDayOfWeek == 1)
{
  Console.WriteLine("Понедельник");
}
if (numberDayOfWeek == 2)
{
  Console.WriteLine("Вторник");
}
if (numberDayOfWeek == 3)
{
  Console.WriteLine("Среда");
}
if (numberDayOfWeek == 4)
{
  Console.WriteLine("Четверг");
}
if (numberDayOfWeek == 5)
{
  Console.WriteLine("Пятница");
}
if (numberDayOfWeek == 6)
{
  Console.WriteLine("Суббота");
}
if (numberDayOfWeek == 7)
{
  Console.WriteLine("Воскресенье");
}
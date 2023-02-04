// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.Clear();
Console.WriteLine("Первый метод");
Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine()!);
if (number < 100 || number > 999)
{
  Console.Write("Неправильное число: ");
  return;
}
int otvet = number % 10;
Console.WriteLine($"Последняя цифра: {otvet}");

Console.WriteLine("------------------");
Console.WriteLine("Второй метод");
Console.Write("Введите трёхзначное число: ");
string num = Console.ReadLine()!;
// if (num < 100 || num > 999) //как здесь надо написать что бы небыло ошибки?
// {
//   Console.Write("Неправильное число: ");
//   return;
// }
string otvet2 = Convert.ToString(num[num.Length -1]);
Console.Write($"Последняя цифра: {otvet2}");


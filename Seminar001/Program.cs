// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
// на само себя).

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int sqrt = number * number;
Console.WriteLine($"Квадрат числ {number} равен: {sqrt}");


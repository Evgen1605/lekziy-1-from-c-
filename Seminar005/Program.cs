// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.Clear();
Console.WriteLine("Первый метод");
Console.Write("Введите трёхзначное число: ");// просим пользователя ввести число
int number = int.Parse(Console.ReadLine()!);// считываем число которое ввёл пользователь
if (number < 100 || number > 999)// сравниваем если у число которое ввёл пользователь меньше 100 или больше 999 
{
  Console.Write("Неправильное число: ");// то выводим в консоль
  return;// и завершаем программу
}
int otvet = number % 10;// создаём переменную в которую кладём число % 10- всегда показывет последнюю цифру например: 123 % 10 = 3, 45 % 10 = 5, 3 % 10 = 3
Console.WriteLine($"Последняя цифра: {otvet}");//выводим в консоль ответ

Console.WriteLine("------------------");
Console.WriteLine("Второй метод");// решаем через переменную типа string(строка)
Console.Write("Введите трёхзначное число: ");
string num = Console.ReadLine()!;// создаём переменную строку
if (num.Length < 3 || num.Length > 3) //сравниваем если длина строки меньше 3 символов или больше 3 символов
{
  Console.Write("Неправильное число: ");// то выводим в консоль предупреждение
  return;//завершаем программу
}
string otvet2 = Convert.ToString(num[num.Length -1]);// к элементам строки обращаемся как элементам массива если записать просто например num[2], то выдаст ошибку что не может char  преоброзовать в string. чтобы её не было нужно преобразовать в string, num[num.Length -1]- если нам не извстно сколько элементов в массиве, мы можем обратиться к последнему, название массива.длина -1 например если ьудет массив из 1234, то покажет последнию цифру 4
Console.Write($"Последняя цифра: {otvet2}");// выводим ответ в консоль


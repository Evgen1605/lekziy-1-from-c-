Console.Write("Введите имя пользователя: ");
string? username = Console.ReadLine();

if (username!.ToLower() == "евгений")
{
  Console.Write("Ура, Это же ЕВГЕНИЙ!");
}
else{
  Console.Write("Привет! " + username);
}
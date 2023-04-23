Console.Write("Введите имя в пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "Маша") // .ToLower() Превращает все заглавные буквы в строчные
{
    Console.WriteLine("Где тебя черти носили, сиповка привокзальная?!");
}
else
{
    Console.WriteLine("Привет, " + username + "!");
}
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "адиль")
{   
    Console.WriteLine("Мистер Адиль!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
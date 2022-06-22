Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "ваня")
{
    Console.WriteLine("Ура, босс Ваня");
}
    else
    {
        Console.Write("Привет, ");
        Console.WriteLine(username);
    }

Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "миша")
{
    Console.WriteLine("Ура это Миша! Привет!");
}
else
{
    Console.Write("Привет! ");
    Console.WriteLine(username);
}
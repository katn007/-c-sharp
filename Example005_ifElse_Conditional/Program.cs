Console.Write("введите свое имя:   ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Мария, приветсвую тебя, моя родная \n");
}
else
{
    Console.WriteLine($"Привет, {username} \n");
}

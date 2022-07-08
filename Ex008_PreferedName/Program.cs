Console.Write("Enter user name: ");
string username = Console.ReadLine();

if(username.ToLower() == "maria")
{
    Console.WriteLine("I love you Maria!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}
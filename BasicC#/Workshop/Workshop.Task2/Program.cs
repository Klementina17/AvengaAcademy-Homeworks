using System.Xml;
using Workshop.Task2.Models;

User[] users = new User[]
{
    new User(1,"KlementinaD","Kimi123",new string[]{"Hello,I am Klementina","Kimi you have missed call."}),
    new User(2,"KirilaD","Kici123",new string[]{"Hello,I am Kirila", "Kirila you have 5 new messages."}),
    new User(3,"MartinD","Martin123",new string[]{"Hello,I am Martin","Martin your message is sent."})
};

bool UserInterface()
{
    Console.Clear();
    Console.WriteLine("1) Login \n2) Register new \n3)Exit");
    bool isChoiceValid = int.TryParse(Console.ReadLine(), out int choice);

    if(!isChoiceValid && choice > 3)
    {
        Console.WriteLine("Please enter valid number from 1-3 to choose one from the options");
        return false;
    }

    switch (choice)
    {
        case 1:
            Login();
            return false;
        case 2:
            Register();
            return false;
        case 3:
            return true;
        default:
            break;
    }
    return false;
}

User FindUser(string username,string password)
{
    foreach(User user in users)
    {
        if(user.Username == username && user.Password == password)
            return user;
    }
    return null;
}
void Login()
{
    User user = FindUser(GetUsernameInput(), GetPasswordInput());

    if (user != null)
    {
        Console.WriteLine("----------------------------");
        Console.WriteLine($"Welcome {user.Username}");
        Console.WriteLine("----------------------------");
        Console.WriteLine("Your messages: ");
        foreach (string msg in user.Messages)
        {
            Console.WriteLine(msg);
        }
        Console.WriteLine("----------------------------");
    }

    Console.WriteLine("Press any key to start over or X to exit!");
    if (Console.ReadLine().ToLower() == "x")
        return;
}

void Register()
{
    string username = GetUsernameInput();
    string password = GetPasswordInput();

    User ExistingUser = FindUser(username, password);

    if (ExistingUser != null)
    {
        Console.WriteLine("User already registered!");
        Console.ReadLine();
        return;
    }

    Array.Resize(ref users, users.Length+1);
    users[users.Length - 1] = new User(users.Length, username, password, null);
    Console.WriteLine("Successfully registered!");
    Console.WriteLine("----------------------------");
    Console.WriteLine("Users registered so far:");
    Console.WriteLine("----------------------------");

    foreach (User user in users)
    {
        Console.WriteLine($"{user.Id} {user.Username}");
    }
    Console.WriteLine("----------------------------");

    Console.WriteLine("Press any key to start over or X to exit!");
    if (Console.ReadLine().ToLower() == "x")
        return;
}
string GetUsernameInput()
{
    Console.WriteLine("Enter username");
    return Console.ReadLine();
}

string GetPasswordInput()
{
    Console.WriteLine("Enter password");
    return Console.ReadLine();
}

while (!UserInterface()) ;
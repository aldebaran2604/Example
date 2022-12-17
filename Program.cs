using TestConsole.Interfaces;
using TestConsole.Models;

IUser user = new User()
{
    Name = "Luis Jose Padilla Benitez",
    Role = new Role()
    {
        Name = "Admin",
        Description = "Administrator"
    }
};

Console.WriteLine("Hello, World!");

Console.WriteLine($"{user.Name}");

Console.WriteLine($"{user.Role.Name}");

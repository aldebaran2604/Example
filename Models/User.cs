using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestConsole.Interfaces;

namespace TestConsole.Models;

public class User : IUser
{
    public string Name { get; set; }
    public IRole Role { get; set; }
}

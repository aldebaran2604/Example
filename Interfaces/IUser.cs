using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsole.Interfaces;

public interface IUser
{
    string Name { get; }
    IRole Role { get; }
}

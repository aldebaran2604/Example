using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestConsole.Interfaces;

namespace TestConsole.Models;

public class Role: IRole
{
    public string Name { get; set; }
    public string Description { get; set; }
}

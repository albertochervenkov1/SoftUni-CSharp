using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo.Contracts
{
    public interface IPerson : IBuyer
    {
        string Name { get; }
        int Age { get; }
    }
}

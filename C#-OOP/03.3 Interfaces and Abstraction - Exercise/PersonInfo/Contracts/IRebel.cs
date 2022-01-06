using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo.Contracts
{
    interface IRebel:IPerson
    {
        string Group { get; }
    }
}

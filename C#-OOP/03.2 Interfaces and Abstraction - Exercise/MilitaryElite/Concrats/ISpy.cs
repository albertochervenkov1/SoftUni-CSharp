using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Concrats
{
    public interface ISpy:ISoldier
    {
        int CodeNumber { get; }
    }
}

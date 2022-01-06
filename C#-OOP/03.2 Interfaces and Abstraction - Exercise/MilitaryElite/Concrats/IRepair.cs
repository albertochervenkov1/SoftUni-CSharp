using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Concrats
{
    public interface IRepair
    {
        string PartName { get; }
        int HoursWorked { get; }

    }
}

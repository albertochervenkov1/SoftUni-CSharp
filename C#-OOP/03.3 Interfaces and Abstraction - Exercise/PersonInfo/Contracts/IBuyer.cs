using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo.Contracts
{
    public interface IBuyer
    {
        int Food { get; }
        void BuyFood();
    }
}

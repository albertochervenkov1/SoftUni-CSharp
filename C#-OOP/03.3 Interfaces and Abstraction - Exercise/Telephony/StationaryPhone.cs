using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : Phone
    {
        public override string Call(string phoneNumber)
        {
            if (phoneNumber.Any(x => !char.IsDigit(x)))
            {
                throw new InvalidOperationException("Invalid number!");
            }
            return $"Dialing... {phoneNumber}";
        }
    }
}

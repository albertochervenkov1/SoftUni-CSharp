using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo.Contracts
{
    public interface ICitizen:IPerson,IIdentifiable,IBirthable
    {
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Concrats
{
    public interface ILieutenantGeneral : IPrivate
    {
        IReadOnlyCollection<IPrivate> Privates { get; }

        void AddPrivate(IPrivate @private);
    }
}

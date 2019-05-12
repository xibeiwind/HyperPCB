using System;
using System.Collections.Generic;

namespace HyperPCB.Core
{
    public interface IPinQueryService
    {
        void Register(IPin pin);
        void UnRegister(IPin pin);
        IEnumerable<IPin> FindByResource<TResource>();
        IEnumerable<IPin> Find(Func<IPin, bool> predicate);
    }
}
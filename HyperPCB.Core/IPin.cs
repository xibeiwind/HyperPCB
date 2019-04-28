using System;

namespace HyperPCB.Core
{
    public interface IPin
    {
        Guid Id { get; }
        string Name { get; }

    }
}
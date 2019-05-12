using System;
using HyperPCB.Core.Enums;

namespace HyperPCB.Core
{
    public interface IPin
    {
        Guid Id { get; }
        string Name { get; }
        PinType Type { get; }
    }
}
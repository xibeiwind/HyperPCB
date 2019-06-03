using System;

namespace HyperPCB.Core
{
    public interface IPinConnection
    {
    }

    public interface IPinConnection<TResource> : IPinConnection
        where TResource : IResource
    {
        Guid Id { get; }
        IProcessNodeInputPin<TResource> In { get; }
        IProcessNodeOutputPin<TResource> Out { get; }
    }
}
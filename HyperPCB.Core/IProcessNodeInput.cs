using System;

namespace HyperPCB.Core
{
    public interface IProcessNodeInput
    {
        Guid Id { get; set; }
    }

    public interface IProcessNodeInput<out TResource>
        where TResource : IResource
    {
        TResource Resource { get; }
    }
}
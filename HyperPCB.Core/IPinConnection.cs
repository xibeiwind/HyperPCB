using System;

namespace HyperPCB.Core
{
    public interface IPinConnection
    {
        Guid Id { get; }
        IProcessNodeInputPin In { get; set; }
        IProcessNodeOutputPin Out { get; set; }
    }
}
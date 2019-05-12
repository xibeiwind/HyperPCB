using System;
using System.Collections.Generic;
using HyperPCB.Core.Enums;

namespace HyperPCB.Core
{
    public interface IProcessNode
    {
        Guid Id { get; }
        string Name { get; }
        ProcessNodeState NodeState { get; }
        IEnumerable<IProcessNodeInputPin> InputPins { get; }
        IEnumerable<IProcessNodeOutputPin> OutputPins { get; }
        IProcessNodeContext Context { get; }
    }
}
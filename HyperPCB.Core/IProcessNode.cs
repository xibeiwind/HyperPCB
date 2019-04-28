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
        IProcessNodeContext NodeContext { get; }
        IEnumerable<IProcessNodeInputPin> InputPins { get; }
        IEnumerable<IProcessNodeOutputPin> OutputPins { get; }
    }
}
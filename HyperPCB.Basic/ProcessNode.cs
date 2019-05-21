using System;
using System.Collections.Generic;
using HyperPCB.Core;
using HyperPCB.Core.Enums;

namespace HyperPCB.Basic
{
    public class ProcessNode: IProcessNode
    {

        public Guid Id { get; }
        public string Name { get; }
        public ProcessNodeState NodeState { get; }
        public IProcessNodeContext NodeContext { get; }
        public IEnumerable<IProcessNodeInputPin> InputPins { get; }
        public IEnumerable<IProcessNodeOutputPin> OutputPins { get; }
    }
}

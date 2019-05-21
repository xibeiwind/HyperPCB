using System;
using System.Collections.Generic;
using HyperPCB.Core;
using HyperPCB.Core.Enums;

namespace HyperPCB.Local
{
    public class ProcessNode : IProcessNode
    {
        public IProcessNodeContext NodeContext { get; }

        public Guid Id { get; }
        public string Name { get; }
        public ProcessNodeState NodeState { get; }
        public IEnumerable<IProcessNodeInputPin> InputPins { get; }
        public IEnumerable<IProcessNodeOutputPin> OutputPins { get; }
        public IProcessNodeContext Context { get; }
    }
}
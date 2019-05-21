﻿using System;
using System.Collections.Generic;
using HyperPCB.Core;
using HyperPCB.Core.Enums;

namespace HyperPCB.Local
{
    class ProcessFlow : IProcessFlow
    {
        public Guid Id { get; } 
        public string Name { get; }
        public ProcessNodeState NodeState { get; }
        public IEnumerable<IProcessNodeInputPin> InputPins { get; }
        public IEnumerable<IProcessNodeOutputPin> OutputPins { get; }
        public IProcessNodeContext Context { get; }
        public IEnumerable<IProcessNode> Nodes { get; }
        public IEnumerable<IPinConnection> Connections { get; }
        public IProcessFlowContext FlowContext { get; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using HyperPCB.Core;
using HyperPCB.Core.Enums;

namespace HyperPCB.Local
{
    public sealed class ProcessFlow : IProcessFlow
    {
        public ProcessFlow(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public Guid Id { get; }
        public string Name { get; }
        public ProcessNodeState NodeState { get; } = ProcessNodeState.Standby;
        public IEnumerable<IProcessNodeInputPin> InputPins { get; } = new HashSet<IProcessNodeInputPin>();
        public IEnumerable<IProcessNodeOutputPin> OutputPins { get; } = new HashSet<IProcessNodeOutputPin>();
        public IProcessNodeContext Context { get; }


        public void ResourceArrived(IResource resource)
        {
        }

        public IEnumerable<IProcessNode> Nodes { get; } = new HashSet<IProcessNode>();
        public IEnumerable<IPinConnection> Connections { get; } = new HashSet<IPinConnection>();
        public IProcessFlowContext FlowContext { get; } = new ProcessFlowContext();

        public void AddProcessNode(IProcessNode node)
        {
            if (Nodes is HashSet<IProcessNode> nodeSet) nodeSet.Add(node);
        }

        public void RemoveProcessNode(IProcessNode node)
        {
            if (Nodes is HashSet<IProcessNode> nodeSet)
                if (nodeSet.Contains(node))
                {
                    if (Connections is HashSet<IPinConnection> connectionSet)
                        connectionSet.RemoveWhere(a => a.IsLinkTo(node));
                    if (InputPins is HashSet<IProcessNodeInputPin> inputPinSet)
                        inputPinSet.RemoveWhere(a => node.InputPins.Contains(a));
                    if (OutputPins is HashSet<IProcessNodeOutputPin> outputPinSet)
                        outputPinSet.RemoveWhere(a => node.OutputPins.Contains(a));
                    nodeSet.Remove(node);
                }
        }

        public void AddPinConnection(IPinConnection connection)
        {
            if (Connections is HashSet<IPinConnection> connectionSet) connectionSet.Add(connection);
        }

        public void RemovePinConnection(IPinConnection connection)
        {
            if (Connections is HashSet<IPinConnection> connectionSet)
                connectionSet.RemoveWhere(a => a.Equals(connection));
        }
    }
}
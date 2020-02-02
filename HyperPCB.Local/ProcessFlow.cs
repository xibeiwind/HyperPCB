using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HyperPCB.Core;
using HyperPCB.Core.Enums;
using Yunyong.Core;

namespace HyperPCB.Local
{
    public sealed class ProcessFlow : ProcessNode, IProcessFlow
    {

        public ProcessFlow(string name, Guid id) : base(null, name, id)
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



        protected override IEnumerable<IProcessNodeInputPin> InitInputPins()
        {

            return new HashSet<IProcessNodeInputPin>
            {
                //ProcessFlowPinHelper.GetInputPin(this)
            };
        }

        protected override IEnumerable<IProcessNodeOutputPin> InitOutputPins()
        {
            return new HashSet<IProcessNodeOutputPin>
            {
                //ProcessFlowPinHelper.GetOutputPin()
            };
        }

        public override async Task StartAsync()
        {
            foreach (var node in Nodes)
            {
                await node.StartAsync();
            }
        }

        public override async Task StopAsync()
        {
            foreach (var node in Nodes)
            {
                await node.StopAsync();
            }
        }

        protected override void ResourceArrived(IResource resource)
        {

        }
    }

    //public static class ProcessFlowPinHelper
    //{
    //    internal static IProcessNodeInputPin<IProcessNodeInputPin> GetInputPin(IProcessFlow node)
    //    {
    //        var pin = new ProcessNodeInputPin<IProcessNodeInputPin>(GuidUtil.NewSequentialId());
    //        pin.NotifyReceived += (sender, e) => { node.ResourceArrived(e); };
    //        return pin;
    //    }
    //}
}
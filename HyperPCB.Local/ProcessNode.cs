using System;
using System.Collections.Generic;
using System.Linq;
using HyperPCB.Core;
using HyperPCB.Core.Enums;

namespace HyperPCB.Local
{
    public abstract class ProcessNode : IProcessNode
    {
        public IProcessNodeContext NodeContext { get; }

        public Guid Id { get; }
        public string Name { get; }
        public ProcessNodeState NodeState { get; protected set; }
        public IEnumerable<IProcessNodeInputPin> InputPins { get; }
        public IEnumerable<IProcessNodeOutputPin> OutputPins { get; }
        public IProcessNodeContext Context { get; }
        protected abstract void ResourceArrived(IResource resource);

        void IProcessNode.ResourceArrived(IResource resource)
        {
            this.ResourceArrived(resource);
        }

        protected IProcessNodeOutputPin GetOutputPin(string pinName)
        {
            return OutputPins.FirstOrDefault(a => a.Name == pinName);
        }

        protected IProcessNodeInputPin GetInputPin(string pinName)
        {
            return InputPins.FirstOrDefault(a => a.Name == pinName);
        }

        protected ProcessNode(IProcessNodeContext context, string name, Guid id)
        {
            Context = context;
            Name = name;
            Id = id;
            InputPins = _InitInputPins();

            OutputPins = _InitOutputPins();

        }

        private IEnumerable<IProcessNodeOutputPin> _InitOutputPins()
        {
            return InitOutputPins();
        }

        private IEnumerable<IProcessNodeInputPin> _InitInputPins()
        {
            return InitInputPins();
        }
        protected abstract IEnumerable<IProcessNodeInputPin> InitInputPins();

        protected abstract IEnumerable<IProcessNodeOutputPin> InitOutputPins();
    }
}
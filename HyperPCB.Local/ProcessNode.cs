using System;
using System.Collections.Generic;
using System.Linq;
using HyperPCB.Core;
using HyperPCB.Core.Enums;

namespace HyperPCB.Local
{
    public abstract class ProcessNode : IProcessNode
    {
        protected ProcessNode(IProcessNodeContext context, string name, Guid id)
        {
            Context = context;
            Name = name;
            Id = id;
            InputPins = _InitInputPins();

            OutputPins = _InitOutputPins();
        }

        public IProcessNodeContext NodeContext { get; }

        public Guid Id { get; }
        public string Name { get; }
        public ProcessNodeState NodeState { get; protected set; }
        public IEnumerable<IProcessNodeInputPin> InputPins { get; }
        public IEnumerable<IProcessNodeOutputPin> OutputPins { get; }
        public IProcessNodeContext Context { get; }

        void IProcessNode.ResourceArrived(IResource resource)
        {
            ResourceArrived(resource);
        }

        protected abstract void ResourceArrived(IResource resource);

        protected IProcessNodeOutputPin GetOutputPin(string pinName)
        {
            return OutputPins.FirstOrDefault(a => a.Name == pinName);
        }

        protected IProcessNodeInputPin<TResource> GetInputPin<TResource>() where TResource : IResource
        {
            return InputPins.FirstOrDefault(a => a.GetType().IsSubclassOf(typeof(IProcessNodeInputPin<TResource>)))
                as IProcessNodeInputPin<TResource>;
        }

        protected IProcessNodeOutputPin<TResource> GetOutputPin<TResource>() where TResource : IResource
        {
            return OutputPins.FirstOrDefault(a => a.GetType().IsSubclassOf(typeof(IProcessNodeOutputPin<TResource>)))
                as IProcessNodeOutputPin<TResource>;
        }

        protected IProcessNodeInputPin GetInputPin(string pinName)
        {
            return InputPins.FirstOrDefault(a => a.Name == pinName);
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
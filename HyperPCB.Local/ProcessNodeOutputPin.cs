using System;
using System.Threading.Tasks;
using HyperPCB.Core;
using HyperPCB.Core.Enums;

namespace HyperPCB.Local
{
    public class ProcessNodeOutputPin<TResource> : IProcessNodeOutputPin<TResource>
        where TResource : IResource
    {
        private ProcessNodeOutputPin()
        {

        }
        public ProcessNodeOutputPin(Guid id, string name = default)
        {
            Id = id;
            Name = name ?? $"{typeof(TResource).Name}OutputPin";
        }

        public async Task Send(IProcessNodeOutput<TResource> output)
        {
            NotifySend?.Invoke(this, output.Resource);
        }

        public Guid Id { get; }
        public string Name { get; }
        public PinType Type { get; } = PinType.PinOut;

        public event EventHandler<TResource> NotifySend;
    }
}
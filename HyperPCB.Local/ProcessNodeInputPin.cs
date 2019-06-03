using System;
using System.Threading.Tasks;
using HyperPCB.Core;
using HyperPCB.Core.Enums;

namespace HyperPCB.Local
{
    public class ProcessNodeInputPin<TResource> : IProcessNodeInputPin<TResource>
        where TResource : IResource
    {
        public ProcessNodeInputPin(Guid id, string name = default)
        {
            Id = id;
            Name = name ?? $"{typeof(TResource).Name}InputPin";
        }

        public async Task Receive(IProcessNodeInput<TResource> input)
        {
            NotifyReceived?.Invoke(this, input.Resource);
        }

        public Guid Id { get; }
        public string Name { get; }
        public PinType Type { get; } = PinType.PinIn;

        public event EventHandler<TResource> NotifyReceived;
    }
}
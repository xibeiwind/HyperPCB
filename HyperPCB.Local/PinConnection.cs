using System;
using HyperPCB.Core;

namespace HyperPCB.Local
{
    public class PinConnection<TResource> : IPinConnection<TResource> where TResource : IResource
    {
        public PinConnection(Guid id, ProcessNodeInputPin<TResource> inPin, ProcessNodeOutputPin<TResource> outPin)
        {
            Id = id;
            InPin = inPin;
            OutPin = outPin;

            OutPin.NotifySend += async (sender, resource) => { await InPin.Receive(resource.ToInput()); };
        }

        private ProcessNodeInputPin<TResource> InPin { get; }
        private ProcessNodeOutputPin<TResource> OutPin { get; }

        public Guid Id { get; }
        public IProcessNodeInputPin<TResource> In => InPin;
        public IProcessNodeOutputPin<TResource> Out => OutPin;
    }
}
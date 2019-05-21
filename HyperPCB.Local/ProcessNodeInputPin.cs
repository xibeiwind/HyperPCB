using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyperPCB.Core;
using HyperPCB.Core.Enums;

namespace HyperPCB.Local
{
    public class ProcessNodeInputPin<TResource> : IProcessNodeInputPin<TResource>
        where TResource : IResource
    {
        public event EventHandler<TResource> NotifyReceived;
        public async Task Receive(IProcessNodeInput<TResource> input)
        {
            NotifyReceived?.Invoke(this, input.Resource);
        }

        public Guid Id { get; }
        public string Name { get; }
        public PinType Type { get; } = PinType.PinIn;
    }
}

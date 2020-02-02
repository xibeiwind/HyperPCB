using HyperPCB.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyperPCB.Serve
{
    public abstract class Plugin : ProcessFlow, IPlugin
    {
        public Plugin( string name, Guid id) : base( name, id)
        {

        }

        protected override IEnumerable<IProcessNodeInputPin> InitInputPins()
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<IProcessNodeOutputPin> InitOutputPins()
        {
            throw new NotImplementedException();
        }

        protected override Task OnStartAsync()
        {
            throw new NotImplementedException();
        }

        protected override Task OnStopAsync()
        {
            throw new NotImplementedException();
        }

        protected override void ResourceArrived(IResource resource)
        {
            throw new NotImplementedException();
        }

    }
}

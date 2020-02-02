using HyperPCB.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperPCB.Serve
{
    public class ProcessFlow : ProcessNode, IProcessFlow
    {
        public ProcessFlow(string name, Guid id) : base(null, name, id)
        {
        }

        public IEnumerable<IProcessNode> Nodes => throw new NotImplementedException();

        public IEnumerable<IPinConnection> Connections => throw new NotImplementedException();

        public IProcessFlowContext FlowContext => throw new NotImplementedException();

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

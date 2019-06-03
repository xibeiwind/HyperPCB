using System;
using System.Collections.Generic;
using HyperPCB.Core;

namespace HyperPCB.Local.Notify
{
    public class NotifyProcessNode : ProcessNode
    {
        public NotifyProcessNode(string name, Guid id) : base(new NotifyProcessNodeContext(), name, id)
        {
        }

        protected override void ResourceArrived(IResource resource)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<IProcessNodeInputPin> InitInputPins()
        {
            return new HashSet<IProcessNodeInputPin>
            {
                NotifyProcessPinHelper.GetInputPin(this)
            };
        }

        protected override IEnumerable<IProcessNodeOutputPin> InitOutputPins()
        {
            return new HashSet<IProcessNodeOutputPin>
            {
                NotifyProcessPinHelper.GetOutputPin()
            };
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyperPCB.Core;
using Yunyong.Core;

namespace HyperPCB.Local.Notify
{
    public class NotifyProcessNode : ProcessNode
    {
        public NotifyProcessNode(IProcessNodeContext context, string name, Guid id) : base(context, name, id)
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
                NotifyProcessPinHelper.GetInputPin(),
            };
        }

        protected override IEnumerable<IProcessNodeOutputPin> InitOutputPins()
        {

            return new HashSet<IProcessNodeOutputPin>
            {
                NotifyProcessPinHelper.GetOutputPin(),
            };
        }
    }

    public class NotifyProcessNodeContext : IProcessNodeContext
    {

    }

    public static class NotifyProcessPinHelper
    {
        internal static IProcessNodeInputPin<NotifySendApplyEvent> GetInputPin()
        {
            return new ProcessNodeInputPin<NotifySendApplyEvent>(GuidUtil.NewSequentialId());
        }

        internal static IProcessNodeOutputPin<NotifySendApplyEvent> GetOutputPin()
        {
            return new ProcessNodeOutputPin<NotifySendApplyEvent>(GuidUtil.NewSequentialId());
        }
    }

    public class NotifySendApplyEvent : IResource
    {
        public NotifySendApplyEvent(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}

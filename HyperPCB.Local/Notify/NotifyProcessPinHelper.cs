using HyperPCB.Core;
using Yunyong.Core;

namespace HyperPCB.Local.Notify
{
    public static class NotifyProcessPinHelper
    {
        internal static IProcessNodeInputPin<NotifySendApplyEvent> GetInputPin(IProcessNode node)
        {
            var pin = new ProcessNodeInputPin<NotifySendApplyEvent>(GuidUtil.NewSequentialId());
            pin.NotifyReceived += (sender, e) => { node.ResourceArrived(e); };
            return pin;
        }

        internal static IProcessNodeOutputPin<NotifySendApplyEvent> GetOutputPin()
        {
            return new ProcessNodeOutputPin<NotifySendApplyEvent>(GuidUtil.NewSequentialId());
        }
    }
}
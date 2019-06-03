using HyperPCB.Core;
using HyperPCB.Local.Notify;
using Yunyong.Core;

namespace HyperPCB.Local.Emails
{
    public class EmailProcessPinHelper
    {
        internal static IProcessNodeInputPin<EmailSendApplyEvent> GetEmailInputPin(IProcessNode node)
        {
            var pin = new ProcessNodeInputPin<EmailSendApplyEvent>(GuidUtil.NewSequentialId(),
                $"{nameof(EmailSendApplyEvent)}InputPin");
            pin.NotifyReceived += (o, e) => { node.ResourceArrived(e); };
            return pin;
        }

        internal static IProcessNodeInputPin<NotifySendApplyEvent> GetInputPin()
        {
            var pin = new ProcessNodeInputPin<NotifySendApplyEvent>(GuidUtil.NewSequentialId());
            pin.NotifyReceived += (s, e) => { }
                ;

            return pin;
        }

        internal static IProcessNodeOutputPin<EmailSendProcessedEvent> GetEmailOutputPin()
        {
            var pin = new ProcessNodeOutputPin<EmailSendProcessedEvent>(GuidUtil.NewSequentialId(),
                $"{nameof(EmailSendProcessedEvent)}OutputPin");

            return pin;
        }

        internal static IProcessNodeOutputPin<EmailSendProcessedEvent> GetEmailSendProcessedPin()
        {
            return new ProcessNodeOutputPin<EmailSendProcessedEvent>(GuidUtil.NewSequentialId());
        }

        public static IProcessNodeInputPin GetNotifyInputPin(IProcessNode node)
        {
            var pin = new ProcessNodeInputPin<NotifySendApplyEvent>(GuidUtil.NewSequentialId(),
                $"{nameof(NotifySendApplyEvent)}InputPin");
            pin.NotifyReceived += (o, e) => { node.ResourceArrived(e); };
            return pin;
        }

    }
}
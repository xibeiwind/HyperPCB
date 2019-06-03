using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HyperPCB.Core;
using HyperPCB.Local.Notify;

namespace HyperPCB.Local.Emails
{
    public sealed partial class EmailProcessNode : ProcessNode
    {
        public EmailProcessNode(EmailProcessNodeContext context, string name, Guid id) :
            base(context, name, id)
        {
            EmailContext = context;
        }

        private EmailProcessNodeContext EmailContext { get; }

        protected override IEnumerable<IProcessNodeOutputPin> InitOutputPins()
        {
            return new HashSet<IProcessNodeOutputPin>()
            {
                EmailProcessPinHelper.GetEmailSendProcessedPin(),
            };
        }

        protected override void ResourceArrived(IResource resource)
        {
            switch (resource)
            {
                case EmailSendApplyEvent emailSendApply:
                    break;
                case NotifySendApplyEvent notifySendApply:
                    SendEmail(notifySendApply);
                    break;
            }
        }

        public override async Task StartAsync()
        {
        }

        public override async Task StopAsync()
        {
        }

        protected override IEnumerable<IProcessNodeInputPin> InitInputPins()
        {
            return new HashSet<IProcessNodeInputPin>
            {
                EmailProcessPinHelper.GetEmailInputPin(this),
                EmailProcessPinHelper.GetNotifyInputPin(this),
            };
        }
    }

    //public class 
}
using System;
using System.Collections.Generic;
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
            return new HashSet<IProcessNodeOutputPin>();
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

        protected override IEnumerable<IProcessNodeInputPin> InitInputPins()
        {
            return new HashSet<IProcessNodeInputPin>
            {
                EmailProcessPinHelper.GetEmailInputPin(this)
            };
        }
    }

    //public class 
}
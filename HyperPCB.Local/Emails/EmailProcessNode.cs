using System;
using System.Collections.Generic;
using HyperPCB.Core;
using HyperPCB.Core.Enums;
using HyperPCB.Local.Notify;

namespace HyperPCB.Local.Emails
{
    public class EmailProcessNode : ProcessNode
    {

        private EmailProcessNodeContext EmailContext { get; }

        public EmailProcessNode(EmailProcessNodeContext context, string name) : base(context, name, id: Guid.Empty)
        {
            this.EmailContext = context;
        }

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
                    break;
            }
        }

        protected override IEnumerable<IProcessNodeInputPin> InitInputPins()
        {

            return new HashSet<IProcessNodeInputPin>
            {
                EmailProcessPinHelper.GetEmailInputPin(this),
            };
        }
    }

    //public class 
}
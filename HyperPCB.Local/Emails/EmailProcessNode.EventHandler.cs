using System;
using HyperPCB.Local.Notify;

namespace HyperPCB.Local.Emails
{
    public sealed partial class EmailProcessNode
    {
        private void SendEmail(NotifySendApplyEvent notify)
        {
            var content = $@"
From:{notify.FromId}
To:{notify.ToId}
Subject:{notify.Title}
Type:{notify.Type}
Content:{notify.Content}
Sign: {EmailContext.GetSign()}
";

            Console.WriteLine(content);

            var pin = GetOutputPin<EmailSendProcessedEvent>();
            pin.Send(new ProcessNodeOutput<EmailSendProcessedEvent>(new EmailSendProcessedEvent(notify.Id)));
        }
    }
}
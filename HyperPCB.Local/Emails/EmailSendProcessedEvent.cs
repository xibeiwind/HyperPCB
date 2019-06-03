using System;
using HyperPCB.Core;

namespace HyperPCB.Local.Emails
{
    public class EmailSendProcessedEvent : IResource
    {
        public EmailSendProcessedEvent(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}
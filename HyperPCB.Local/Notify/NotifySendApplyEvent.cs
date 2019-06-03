using System;
using HyperPCB.Core;

namespace HyperPCB.Local.Notify
{
    public class NotifySendApplyEvent : IResource
    {
        public NotifySendApplyEvent(Guid id)
        {
            Id = id;
        }

        public Guid FromId { get; set; }
        public Guid ToId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public NotifyType Type { get; set; }

        public Guid Id { get; }
    }
}
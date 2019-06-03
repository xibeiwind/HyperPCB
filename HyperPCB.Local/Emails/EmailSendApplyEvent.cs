using System;
using HyperPCB.Core;

namespace HyperPCB.Local.Emails
{
    public class EmailSendApplyEvent : IResource
    {
        public EmailSendApplyEvent(Guid id, string @from, string to, string title, string content)
        {
            Id = id;
            From = @from;
            To = to;
            Title = title;
            Content = content;
        }

        public string From { get;  }
        public string To { get;  }
        public string Title { get;  }
        public string Content { get;  }
        public Guid Id { get; private set; }
    }
}
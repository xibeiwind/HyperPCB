using HyperPCB.Core;

namespace HyperPCB.Local.Emails
{
    public class EmailSendApply : IResource
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
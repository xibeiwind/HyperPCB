using System;
using System.Collections.Generic;
using HyperPCB.Core;
using HyperPCB.Core.Enums;

namespace HyperPCB.Local.Emails
{
    public class EmailProcessNode : IProcessNode
    {
        public Guid Id { get; }
        public string Name { get; }
        public ProcessNodeState NodeState { get; private set; }
        public IEnumerable<IProcessNodeInputPin> InputPins { get; }
        public IEnumerable<IProcessNodeOutputPin> OutputPins { get; }
        public IProcessNodeContext Context => EmailContext;

        private EmailProcessNodeContext EmailContext { get; }

        public EmailProcessNode(EmailProcessNodeContext context, string name)
        {
            this.EmailContext = context;
            Name = name;

            var inputPins = InitInputPins();
            InputPins = inputPins;

            OutputPins = new HashSet<IProcessNodeOutputPin>();
        }

        private HashSet<IProcessNodeInputPin> InitInputPins()
        {
            var pin = new ProcessNodeInputPin<EmailSendApply> { };
            pin.NotifyReceived += EmailPin_NotifyReceived;
            return new HashSet<IProcessNodeInputPin> { pin };
        }

        private void EmailPin_NotifyReceived(object sender, EmailSendApply e)
        {
            Console.WriteLine($@"SendEmail: 
From: {e.From}
To: {e.To}
Title: {e.Title}
Content: {e.Content}

Thanks!
Send By: [{Name}]!
");
        }
    }

    //public class 
}
using HyperPCB.Core;

namespace HyperPCB.Local.Emails
{
    public class EmailProcessNodeContext : IProcessNodeContext
    {
        public EmailProcessNodeContext(string sign)
        {
            Sign = sign;
        }

        private string Sign { get; }

        public string GetSign()
        {
            return Sign;
        }
    }
}
using HyperPCB.Core;

namespace HyperPCB.Local
{
    public static class PinConnectionExtensions
    {
        public static bool IsLinkTo(this IPinConnection connection, IProcessNode node)
        {
            return false;
        }
    }
}
namespace HyperPCB.Core
{
    public interface IProcessNodeOutputPin : IPin
    {
        void LinkTo(IProcessNodeInputPin inputPin);
        void UnLink(IProcessNodeInputPin inputPin);
    }
}
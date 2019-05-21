namespace HyperPCB.Core
{
    public interface IProcessNodeInputPin : IPin
    {

    }
    public interface IProcessNodeInputPin<TResource> : IProcessNodeInputPin
        where TResource : IResource
    {
    }
}
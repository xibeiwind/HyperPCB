namespace HyperPCB.Core
{
    public interface IProcessNodeOutputPin : IPin
    {

    }
    public interface IProcessNodeOutputPin<TResource> : IProcessNodeOutputPin
        where TResource : IResource
    {
    }
}
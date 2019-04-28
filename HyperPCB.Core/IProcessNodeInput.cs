namespace HyperPCB.Core
{
    public interface IProcessNodeInput
    {

    }

    public interface IProcessNodeInput<out TResource>
        where TResource : IResource
    {
        TResource Resource { get; }
    }
}
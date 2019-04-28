namespace HyperPCB.Core
{
    public interface IProcessNodeOutput
    {
    }

    public interface IProcessNodeOutput<out TResource>
        where TResource : IResource
    {
        TResource Resource { get; }
    }
}
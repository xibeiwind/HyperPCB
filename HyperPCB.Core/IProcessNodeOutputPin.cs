using System.Threading.Tasks;

namespace HyperPCB.Core
{
    public interface IProcessNodeOutputPin : IPin
    {
    }

    public interface IProcessNodeOutputPin<in TResource> : IProcessNodeOutputPin
        where TResource : IResource
    {
        Task Send(IProcessNodeOutput<TResource> output);
    }
}
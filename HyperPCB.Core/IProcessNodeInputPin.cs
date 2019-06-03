using System.Threading.Tasks;

namespace HyperPCB.Core
{
    public interface IProcessNodeInputPin : IPin
    {
    }

    public interface IProcessNodeInputPin<in TResource> : IProcessNodeInputPin
        where TResource : IResource
    {
        Task Receive(IProcessNodeInput<TResource> input);
    }
}
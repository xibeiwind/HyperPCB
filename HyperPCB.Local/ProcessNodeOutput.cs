using HyperPCB.Core;

namespace HyperPCB.Local
{
    public class ProcessNodeOutput<TResource> : IProcessNodeOutput<TResource>, IProcessNodeInput<TResource>
        where TResource:IResource
    {
        public ProcessNodeOutput(TResource resource)
        {
            Resource = resource;
        }

        public TResource Resource { get; }
    }
}
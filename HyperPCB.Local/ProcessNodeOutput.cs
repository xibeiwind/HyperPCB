using HyperPCB.Core;

namespace HyperPCB.Local
{
    public class ProcessNodeOutput<TResource> : IProcessNodeOutput<TResource>, IProcessNodeInput<TResource>
        where TResource : IResource
    {
        private ProcessNodeOutput()
        {

        }
        public ProcessNodeOutput(TResource resource)
        {
            Resource = resource;
        }

        public TResource Resource { get; }
    }
}
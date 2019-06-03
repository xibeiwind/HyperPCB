using System.Linq;
using System.Threading.Tasks;
using HyperPCB.Core;
using HyperPCB.Services;

namespace HyperPCB.Local
{
    public static class ProcessFlowExtensions
    {
        internal static void Load(this IProcessFlow flow)
        {
        }

        internal static string Save(this IProcessFlow flow)
        {
            return default;
        }

        public static IProcessNodeInputPin<TResource> GetInputPin<TResource>(this IProcessFlow flow) where TResource : IResource
        {
            return flow.InputPins.FirstOrDefault(a => a is IProcessNodeInputPin<TResource>)
                as IProcessNodeInputPin<TResource>;
        }

        public static IProcessNodeOutputPin<TResource> GetOutputPin<TResource>(this IProcessFlow flow) where TResource : IResource
        {
            return flow.OutputPins.FirstOrDefault(a => a is IProcessNodeOutputPin<TResource>)
                as IProcessNodeOutputPin<TResource>;
        }

        public static IProcessNodeInputPin<TResource> GetInputPin<TResource>(this IProcessNode node) where TResource : IResource
        {
            return node.InputPins.FirstOrDefault(a => a is IProcessNodeInputPin<TResource>)
                as IProcessNodeInputPin<TResource>;
        }

        public static IProcessNodeOutputPin<TResource> GetOutputPin<TResource>(this IProcessNode node) where TResource : IResource
        {
            return node.OutputPins.FirstOrDefault(a => a is IProcessNodeOutputPin<TResource>)
                as IProcessNodeOutputPin<TResource>;
        }
    }
}
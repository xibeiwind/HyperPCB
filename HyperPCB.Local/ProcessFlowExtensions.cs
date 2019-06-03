using System.Threading.Tasks;
using HyperPCB.Core;
using HyperPCB.Services;

namespace HyperPCB.Local
{
    internal static class ProcessFlowExtensions
    {
        public static async Task InitAsync(this IProcessFlow flow, IPinQueryService pinQueryService)
        {
            // deploy settings
            foreach (var node in flow.Nodes) await node.InitAsync();
        }

        internal static void Load(this IProcessFlow flow)
        {
        }

        internal static string Save(this IProcessFlow flow)
        {
            return default;
        }
    }
}
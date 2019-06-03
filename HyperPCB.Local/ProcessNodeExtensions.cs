using System.Linq;
using System.Threading.Tasks;
using HyperPCB.Core;

namespace HyperPCB.Local
{
    public static class ProcessNodeExtensions
    {
        public static async Task InitAsync(this IProcessNode node)
        {
        }

        public static async Task InitAsync(this IProcessFlow flow)
        {
            await Task.WhenAll(flow.Nodes.Select(a => a.InitAsync()).ToArray());
        }
    }
}
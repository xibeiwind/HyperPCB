using System.Linq;
using System.Threading.Tasks;
using HyperPCB.Core;
using HyperPCB.Core.Enums;

namespace HyperPCB.Local
{
    public static class ProcessNodeExtensions
    {
        public static async Task InitAsync(this IProcessFlow flow)
        {
            await Task.WhenAll(flow.Nodes.Cast<ProcessNode>().Select(a => a.InitAsync()).ToArray());
        }
    }
}
using System.Threading.Tasks;
using HyperPCB.Core.Enums;

namespace HyperPCB.Core
{
    public interface IProcessFlowEngine
    {
        FlowEngineState State { get; }
        Task InitAsync(IProcessFlow flow);
        Task StartAsync();
        Task StopAsync();
    }
}
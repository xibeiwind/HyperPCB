using System;
using System.Threading.Tasks;
using HyperPCB.Core;
using HyperPCB.Core.Enums;

namespace HyperPCB.Local
{
    public class ProcessFlowEngine : IProcessFlowEngine
    {
        public FlowEngineState State { get; }

        public async Task InitAsync(IProcessFlow flow)
        {
            await flow.InitAsync();
        }

        public Task StartAsync()
        {
            throw new NotImplementedException();
        }

        public Task StopAsync()
        {
            throw new NotImplementedException();
        }
    }
}
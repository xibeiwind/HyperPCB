using System;
using System.Threading.Tasks;
using HyperPCB.Core;
using HyperPCB.Core.Enums;

namespace HyperPCB.Local
{
    public class ProcessFlowEngine : IProcessFlowEngine
    {
        public FlowEngineState State { get; private set; }

        public IProcessFlow Flow { get; private set; }

        public async Task InitAsync(IProcessFlow flow)
        {
            await flow.InitAsync();
            Flow = flow;
            State = FlowEngineState.Standby;
        }

        public async Task StartAsync()
        {
            if (State != FlowEngineState.Standby)
            {
                throw new ArgumentException($"Engine State exception: {State}");
            }
            await this.Flow.StartAsync();
            State = FlowEngineState.Running;
        }

        public async Task StopAsync()
        {
            await this.Flow.StopAsync();
            State = FlowEngineState.Stoped;
        }
    }
}
using HyperPCB.Core.Enums;

namespace HyperPCB.Core
{
    public interface IProcessFlowEngine
    {
        FlowEngineState State { get; }
        void Init(IProcessFlow flow);
        void Start();
        void Stop();
    }
}
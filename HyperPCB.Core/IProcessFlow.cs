using System.Collections.Generic;

namespace HyperPCB.Core
{
    public interface IProcessFlow : IProcessNode
    {
        IProcessFlowContext FlowContext { get; }
        IEnumerable<IProcessNode> Nodes { get; }
    }
}
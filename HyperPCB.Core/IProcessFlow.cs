using System.Collections.Generic;

namespace HyperPCB.Core
{
    public interface IProcessFlow : IProcessNode
    {
        IEnumerable<IProcessNode> Nodes { get; }
        IEnumerable<IPinConnection> Connections { get; }
        IProcessFlowContext FlowContext { get; }
    }
}
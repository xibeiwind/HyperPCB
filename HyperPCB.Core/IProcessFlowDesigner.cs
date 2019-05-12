using System.Collections.Generic;
using HyperPCB.Core.Enums;

namespace HyperPCB.Core
{
    public interface IProcessFlowDesigner
    {
        bool Init(IProcessFlow flow);
        bool Save();
        bool AddNode(IProcessNode node);
        bool RemoveNode(IProcessNode node);
        bool AddConnection(IPinConnection connection);
        bool RemoveConnection(IPinConnection connection);

        IEnumerable<IPinConnection> GetNodeConnections(IProcessNode node, PinType? pinType);
    }
}
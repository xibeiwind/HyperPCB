using System;
using System.Threading.Tasks;
using HyperPCB.Core;
using HyperPCB.Local.Emails;
using HyperPCB.Local.Notify;
using Yunyong.Core;

namespace HyperPCB.Local.TestConsoleApp
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var engine = await BuildProcessFlowEngine();

            await engine.StartAsync();

            Console.ReadLine();
        }

        private static async Task<IProcessFlowEngine> BuildProcessFlowEngine()
        {
            var engine = new ProcessFlowEngine();

            await engine.InitAsync(BuildProcessFlow());
            return engine;
        }

        private static IProcessFlow BuildProcessFlow()
        {
            var flow = new ProcessFlow(GuidUtil.NewSequentialId(), "TestProcessFlow");


            var notifyNode = new NotifyProcessNode("NotifyProcessNode", GuidUtil.NewSequentialId());
            flow.AddProcessNode(notifyNode);
            var context = new EmailProcessNodeContext("send from [Test Console]");

            var emailNode = new EmailProcessNode(context, "EmailProcessNode", GuidUtil.NewSequentialId());
            flow.AddProcessNode(emailNode);

            var pinConnection = new PinConnection<NotifySendApplyEvent>(GuidUtil.NewSequentialId(),
                emailNode.GetInputPin<NotifySendApplyEvent>() as ProcessNodeInputPin<NotifySendApplyEvent>,
                notifyNode.GetOutputPin<NotifySendApplyEvent>() as ProcessNodeOutputPin<NotifySendApplyEvent>);

            flow.AddPinConnection(pinConnection);

            return flow;
        }
    }
}
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

            var flow = BuildProcessFlowEngine();
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


            flow.AddProcessNode(new NotifyProcessNode("NotifyProcessNode", GuidUtil.NewSequentialId()));
            var context = new EmailProcessNodeContext("send from [Test Console]");

            flow.AddProcessNode(new EmailProcessNode(context, "EmailProcessNode", GuidUtil.NewSequentialId()));

            return flow;
        }
    }
}
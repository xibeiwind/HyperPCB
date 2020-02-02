using System;
using System.Threading.Tasks;
using HyperPCB.Core;
using HyperPCB.Local.Emails;
using HyperPCB.Local.Notify;
using Newtonsoft.Json;
using Yunyong.Core;

namespace HyperPCB.Local.TestConsoleApp
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //var engine = await BuildProcessFlowEngine();

            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
            };
            //var json = JsonConvert.SerializeObject(engine, Formatting.Indented, settings);
            //Console.WriteLine(json);

            //var tmp = JsonConvert.DeserializeObject<IProcessFlowEngine>(json, settings);

            ////await engine.StartAsync();

            //await tmp.StartAsync();
            //Console.ReadLine();

            var flow =new ProcessFlow( "TEST", Guid.NewGuid());
            var json = JsonConvert.SerializeObject(flow, Formatting.Indented, settings);
            Console.WriteLine(json);
            var tmp = JsonConvert.DeserializeObject(json, settings);

            var node = new NotifyProcessNode("TestNode", Guid.NewGuid());

            var nodeJson = JsonConvert.SerializeObject(node, settings);
            var tmpNode = JsonConvert.DeserializeObject(nodeJson, settings);
            
        }

        private static async Task<IProcessFlowEngine> BuildProcessFlowEngine()
        {
            var engine = new ProcessFlowEngine();

            await engine.InitAsync(BuildProcessFlow());
            return engine;
        }

        private static IProcessFlow BuildProcessFlow()
        {
            var flow = new ProcessFlow( "TestProcessFlow", GuidUtil.NewSequentialId());


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
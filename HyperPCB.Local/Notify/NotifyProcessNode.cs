using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HyperPCB.Core;
using Yunyong.Core;

namespace HyperPCB.Local.Notify
{
    public class NotifyProcessNode : ProcessNode
    {
        public NotifyProcessNode(string name, Guid id) : base(new NotifyProcessNodeContext(), name, id)
        {
        }

        protected override void ResourceArrived(IResource resource)
        {
            //switch (resource)
            //{
            //    case NotifySendApplyEvent notifyEvent:
            //        var pin = GetOutputPin<NotifySendApplyEvent>();
            //        pin.Send(new ProcessNodeOutput<NotifySendApplyEvent>(notifyEvent));
            //        break;
            //}
        }

        public override Task StartAsync()
        {
            return TestSendNotifyLoopAsync();
        }

        public override async Task StopAsync()
        {

        }

        protected override IEnumerable<IProcessNodeInputPin> InitInputPins()
        {
            return new HashSet<IProcessNodeInputPin>
            {
                NotifyProcessPinHelper.GetInputPin(this)
            };
        }

        protected override IEnumerable<IProcessNodeOutputPin> InitOutputPins()
        {
            return new HashSet<IProcessNodeOutputPin>
            {
                NotifyProcessPinHelper.GetOutputPin()
            };
        }



        public async Task TestSendNotifyLoopAsync()
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(2000);

                Console.WriteLine(i);
                var pin = GetOutputPin<NotifySendApplyEvent>();
                await pin.Send(new ProcessNodeOutput<NotifySendApplyEvent>(
                    new NotifySendApplyEvent(GuidUtil.NewSequentialId())
                    {
                        FromId = GuidUtil.NewSequentialId(),
                        ToId = GuidUtil.NewSequentialId(),
                        Title = $"Test Notify Message {i:000}",
                        Content = $"This is notify content demo {i:0000}",
                        Type = NotifyType.Info
                    }));
            }
        }
    }
}
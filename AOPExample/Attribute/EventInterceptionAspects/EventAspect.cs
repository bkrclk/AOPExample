using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPExample.Attribute.EventInterceptionAspects
{
    public class EventAspect : EventInterceptionAspect
    {
        public override void OnAddHandler(EventInterceptionArgs args)
        {
            Console.WriteLine("Event eklendi");
            args.ProceedAddHandler();
        }
        public override void OnRemoveHandler(EventInterceptionArgs args)
        {
            Console.WriteLine("Event kaldırıldı");
            args.ProceedRemoveHandler();
        }
        public override void OnInvokeHandler(EventInterceptionArgs args)
        {
            Console.WriteLine("Event Invoke Edildi");
            args.ProceedInvokeHandler();
        }
    }
}

using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPExample.Attribute.OnMethodBoundaryAspects
{
    [Serializable]
    public class CheckUserAuthorization : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("CheckUserAuthorization işlemleri yapıldı...", args.Method);

            base.OnEntry(args);
        }
    }
}

using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPExample.Attribute.OnMethodBoundaryAspects
{
    [Serializable]
    public class LogAspect : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("[ {0} ] Metoduna Girildi...", args.Method);

            base.OnEntry(args);
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            Console.WriteLine("[ {0} ] Metodundan Çıkıldı  ...", args.Method);

            base.OnExit(args);
        }
    }
}

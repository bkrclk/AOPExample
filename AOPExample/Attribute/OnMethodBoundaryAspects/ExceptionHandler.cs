using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPExample.OnMethodBoundaryAspects
{
    [Serializable]
    public class ExceptionHandler : OnExceptionAspect
    {
        public override void OnException(MethodExecutionArgs args)
        {
            Console.WriteLine("SampleException Metodunda Hata Oluştu ");

            string msg = string.Format("{0}: Error running {1}. {2}{3}", DateTime.Now, args.Method.Name, args.Exception.Message, args.Exception.StackTrace);
            Console.WriteLine(msg);
            args.FlowBehavior = FlowBehavior.Continue;
        }

    }
}

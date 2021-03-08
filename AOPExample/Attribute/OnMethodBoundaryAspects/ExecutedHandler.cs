using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPExample.Attribute.OnMethodBoundaryAspects
{
    [Serializable]
    public class ExecutedHandler : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            var message = string.Format("{0} : {1} Metoduna Girildi.", DateTime.Now, args.Method.Name);
            Console.WriteLine(message);
        }
        public override void OnSuccess(MethodExecutionArgs args)
        {
            var message = string.Format("{0} : {1} Metodu İşlemi Tamamlandı. ", DateTime.Now, args.Method.Name);
            Console.WriteLine(message);
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            var message = string.Format("{0} : {1} Metodundan Çıkıldı.", DateTime.Now, args.Method.Name);
            Console.WriteLine(message);
        }
        public override void OnException(MethodExecutionArgs args)
        {
            base.OnException(args);
        }
    }
}

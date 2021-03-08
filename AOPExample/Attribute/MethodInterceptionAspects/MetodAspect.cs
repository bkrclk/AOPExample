using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPExample.Attribute.MethodInterceptionAspects
{
    [Serializable]
    public class MetodAspect : MethodInterceptionAspect
    {
        public override void OnInvoke(MethodInterceptionArgs args)
        {
            Console.WriteLine("Invoke edilmeden Önce işlemelr gerçekleştiriliyor");
            args.Proceed();          
            Console.WriteLine("Invoke edildikten Sonra gerçekleştirliyor");
        }
    }
}

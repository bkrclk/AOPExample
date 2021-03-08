using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPExample.Attribute.LocationInterceptionAspects
{
    [Serializable]
    public class LocationAspect : LocationInterceptionAspect
    {
        public override void OnGetValue(LocationInterceptionArgs args)
        {
            Console.WriteLine("Değer alınıyor:");
            args.ProceedGetValue();
        }

        public override void OnSetValue(LocationInterceptionArgs args)
        {
            Console.WriteLine("Değer set ediliyor: " + args.Value);
            args.ProceedSetValue();
        }
    }
}

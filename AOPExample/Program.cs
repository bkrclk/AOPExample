using AOPExample.Attribute;
using AOPExample.Attribute.EventInterceptionAspects;
using AOPExample.Attribute.LocationInterceptionAspects;
using AOPExample.Attribute.MethodInterceptionAspects;
using AOPExample.Attribute.OnMethodBoundaryAspects;
using AOPExample.OnMethodBoundaryAspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleExecute();
            // SampleException();

            //InvokeMetod();

            //Property = "Property Value";
            // Console.WriteLine(Property);

            //MyEvent += new EventHandler(Program_MyEvent);
            //MyEvent(new object(), new EventArgs());

            Console.ReadLine();

        }

        [ExecutedHandler]
        [CheckUserAuthorization]
        [ExceptionHandler]
        [LogAspect]
        public static void SampleExecute()
        {
            var message = string.Format("[---- {0} : SampleExecute Metodu çalışıyor.. ----]", DateTime.Now);
            Console.WriteLine(message);
        }

        [ExceptionHandler] //Attribute olarak Aspect'i ekledik
        private static void SampleException()
        {
            throw new NotImplementedException();
        }

        [MetodAspect]
        public static void InvokeMetod()
        {
            Console.WriteLine("[---- InvokeMetod işlemleri gerçekleştiriyor.. ----]");
        }

        [LocationAspect]
        public static string Property { set; get; }


        [EventAspect]
        protected static event EventHandler MyEvent;
        static void Program_MyEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Event metodu çalışıyor");
        }
    }
}

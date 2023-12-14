using Castle.DynamicProxy;
using Autofac.Extras.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApiDemo.AutoFacAOP
{
    public class AutofacAOP:IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("start");
            invocation.Proceed();
            Console.WriteLine("end");
        }

    }
}

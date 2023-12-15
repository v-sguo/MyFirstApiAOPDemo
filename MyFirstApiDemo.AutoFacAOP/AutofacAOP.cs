using Castle.DynamicProxy;
using Autofac.Extras.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MyFirstApiDemo.AutoFacAOP
{
    public class AutofacAOP:IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            var timer = Stopwatch.StartNew();
            invocation.Proceed();

            timer.Stop();
            Console.WriteLine($"API Name: {invocation.Method.Name}, Duration: {timer.Elapsed.TotalSeconds}");
        }

    }
}

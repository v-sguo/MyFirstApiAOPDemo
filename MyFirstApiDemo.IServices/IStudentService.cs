using Autofac.Extras.DynamicProxy;
using MyFirstApiDemo.AutoFacAOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApiDemo.IServices
{
    [Intercept(typeof(AutofacAOP))]
    public interface IStudentService
    {
        string Get();
        string Set(string name);
    }
}

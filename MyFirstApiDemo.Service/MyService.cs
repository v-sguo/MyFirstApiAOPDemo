using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstApiDemo.Repository;

namespace MyFirstApiDemo.Service
{
    public class MyService: IMyService
    {
        public void DeSomething()
        {
            Console.WriteLine("Do some thing.");
        }
    }
}

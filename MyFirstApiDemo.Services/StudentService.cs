using MyFirstApiDemo.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApiDemo.Services
{
    public class StudentService: IStudentService
    {
        public string Get()
        {
            return "Hello";
        }

        public string Set(string name)
        {
            return $"This is {name}";
        }
    }
}

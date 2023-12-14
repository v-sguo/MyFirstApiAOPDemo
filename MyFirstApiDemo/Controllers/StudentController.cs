using Autofac.Extras.DynamicProxy;
using Microsoft.AspNetCore.Mvc;
using MyFirstApiDemo.AutoFacAOP;
using MyFirstApiDemo.IServices;

namespace MyFirstApiDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet(Name = "StudentGet")]
        public string Get()
        {
            //return "Hello World.";
            return _studentService.Get();
        }

        [HttpPost(Name = "StudentPost")]
        public string Set(string name)
        {
            return _studentService.Set(name);
        }
    }
}

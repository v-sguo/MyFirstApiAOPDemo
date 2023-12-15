using Autofac;
using Autofac.Extensions.DependencyInjection;
using Autofac.Extras.DynamicProxy;
using MyFirstApiDemo.AutoFacAOP;
using MyFirstApiDemo.IServices;
using MyFirstApiDemo.Services;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace MyFirstApiDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
            builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
            {
                var assembly = Assembly.Load("MyFirstApiDemo.Services");
                builder.RegisterType<AutofacAOP>();
                builder.RegisterAssemblyTypes(assembly)
                    .Where(p => p.Name.EndsWith("Service"))
                    .AsImplementedInterfaces()
                    .EnableInterfaceInterceptors();
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

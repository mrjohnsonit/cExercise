using System;
using Autofac;
using Autofac.Configuration;
using Exercise.Domain.Api;
using Exercise.Domain.App;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //define how to build the api and app instances (reads from the app.config)
            var builder = new ContainerBuilder();

            //specifies to setup injection bindings based on 'autofac' node in the app.config
            builder.RegisterModule(new ConfigurationSettingsReader("autofac")); 

            //finalize container definitions
            var container = builder.Build();

            //setup an IoC scope
            using (var scope = container.BeginLifetimeScope())
            {
                //create the message service from the api
                //no direct refernce to the concrete API in this Cli. 
                //Any concrete binding can be added via the 'autofac' node in the app.config.
                var api = scope.Resolve<IMessageService>(); 
                var app = scope.Resolve<IExerciseApp>();

                //depending on app.config this will either write 'Hello World' to console or a file.
                app.WriteMessage(api.GetHelloWorldMessage());

                //allow for viewing of messages before completion
                System.Console.ReadKey();
            }
        }
    }
}

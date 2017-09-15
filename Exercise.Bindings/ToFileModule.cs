using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Exercise.Api;
using Exercise.App.ToConsole;
using Exercise.App.ToFile;
using Exercise.App.ToTrace;
using Exercise.Domain;
using Exercise.Domain.Api;
using Exercise.Domain.App;

namespace Exercise.Bindings
{
    public class ToFileModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            Console.WriteLine($"Loading: {nameof(ToFileModule)}");
            builder.RegisterType<MessageService>().As<IMessageService>();
            builder.RegisterType<StringMessageProvider>().As<IMesssageProvider>();
            builder.RegisterType<ToFile>().As<IExerciseApp>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Exercise.Api;
using Exercise.App.ToConsole;
using Exercise.App.ToFile;
using Exercise.Domain;
using Exercise.Domain.Api;
using Exercise.Domain.App;

namespace Exercise.Bindings
{
    public class ConsoleAppModule : Module
    {
        public bool WriteToFile { get; set; }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MessageService>().As<IMessageService>();
            builder.RegisterType<StringMessageProvider>().As<IMesssageProvider>();

            if (WriteToFile)
            {
                builder.RegisterType<ToFile>().As<IExerciseApp>();
                return;
            }

            builder.RegisterType<ToConsole>().As<IExerciseApp>();
        }
    }
}

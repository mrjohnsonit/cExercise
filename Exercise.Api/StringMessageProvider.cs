using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise.Domain;
using Exercise.Domain.Api;

namespace Exercise.Api
{
    public class StringMessageProvider : IMesssageProvider
    {
        public const string HelloWorld = "Hello World";

        string IMesssageProvider.GetHelloWorldMessage()
        {
            return HelloWorld;
        }
    }
}

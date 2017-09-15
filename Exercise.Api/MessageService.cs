using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise.Domain;
using Exercise.Domain.Api;

namespace Exercise.Api
{
    public class MessageService : IMessageService
    {
        private readonly IMesssageProvider _messageProvider;

        public MessageService(IMesssageProvider messageProvider)
        {
            _messageProvider = messageProvider;
        }

        string IMessageService.GetHelloWorldMessage()
        {
            return _messageProvider.GetHelloWorldMessage();
        }
    }
}

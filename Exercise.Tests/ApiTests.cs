using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise.Api;
using Exercise.Domain.Api;
using Moq;
using NUnit.Framework;

namespace Exercise.Tests
{
    [TestFixture]
    public class ApiTests
    {
        /// <summary>
        /// Testing the concrete instance of IMessageProvider.
        /// </summary>
        [Test]
        public void MessageProviderTest()
        {
            var messageProvider = new StringMessageProvider() as IMesssageProvider;

            Assert.AreEqual(
                StringMessageProvider.HelloWorld, 
                messageProvider.GetHelloWorldMessage());
        }

        /// <summary>
        /// Testing the concrete instance of IMessageService.
        /// This uses a mock instance of IMessageProvider.
        /// </summary>
        [Test]
        public void MessageServiceTest()
        {
            //create mocked provider
            var providerMessage = "testing 123";
            var providerMock = new Mock<IMesssageProvider>();
            var messageService = new MessageService(providerMock.Object) as IMessageService;

            //setup the mock return on the provider
            providerMock.Setup(x => x.GetHelloWorldMessage()).Returns(providerMessage);
            
            //call the service which should return the value in providerMessage
            Assert.AreEqual(providerMessage, messageService.GetHelloWorldMessage());

            //verify the provider was called (should really be expected if the previous statement doesn't fail
            providerMock.Verify(x => x.GetHelloWorldMessage(), Times.Once);

            ////this would fail if uncommented
            //providerMock.Verify(x => x.GenerateMessage(), Times.Exactly(2)); 
        }


    }
}

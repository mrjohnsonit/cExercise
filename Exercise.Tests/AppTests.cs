using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise.App.ToConsole;
using Exercise.Domain.App;
using NUnit.Framework;

namespace Exercise.Tests
{
    [TestFixture]
    public class AppTests
    {
        [Test]
        public void ToConsoleTest()
        {
            using (var sw = new StringWriter())
            {
                //set the console to write to the string writer
                Console.SetOut(sw);

                //setup input and outputs
                var inputValue = "from the console";
                var expectedValue = $"{inputValue}\r\n";

                //create instance of console app
                var consoleApp = new ToConsole() as IExerciseApp;

                //call console app method
                consoleApp.WriteMessage(inputValue);

                //verify
                Assert.AreEqual(expectedValue, sw.ToString());
            }
        }

    }
}

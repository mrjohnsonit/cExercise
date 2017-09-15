using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise.Domain.Api;
using Exercise.Domain.App;

namespace Exercise.App.ToConsole
{
    public class ToConsole : IExerciseApp
    {
        void IExerciseApp.WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}

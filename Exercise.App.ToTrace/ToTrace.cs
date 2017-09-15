using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise.Domain.App;

namespace Exercise.App.ToTrace
{
    public class ToTrace : IExerciseApp
    {
        void IExerciseApp.WriteMessage(string message)
        {
            Trace.WriteLine(message);
        }
    }
}

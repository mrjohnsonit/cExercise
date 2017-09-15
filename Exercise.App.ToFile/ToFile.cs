using Exercise.Domain.App;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.App.ToFile
{
    public class ToFile : IExerciseApp
    {
        void IExerciseApp.WriteMessage(string message)
        {
            var appDir = AppDomain.CurrentDomain.BaseDirectory.TrimEnd(new[] { '\\' });
            var filePath = $@"{appDir}\exercise.txt";
            File.WriteAllText(filePath, message);
            Console.WriteLine($"Message written to:\r\n{filePath}.\r\nPress any key to continue.");
        }
    }
}

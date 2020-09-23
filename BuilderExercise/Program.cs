using System;
using System.Runtime.Remoting;

namespace BuilderExercise
{
    public class CodeBuilder
    {
        public ObjectHandle type;

        public CodeBuilder(string className)
        {
            type = Activator.CreateInstance(null, className);
        }

        public CodeBuilder AddField(string name, string type)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
            Console.WriteLine(cb);
        }
    }
}

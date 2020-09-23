using System;
using System.Collections.Generic;

namespace BuilderExercise
{
    public class CodeBuilder
    {
        public CustomClass newClass;

        public CodeBuilder(string className)
        {
            newClass = new CustomClass(className);
        }

        public CodeBuilder AddField(string name, string type)
        {
            var newField = (name, type);
            newClass.Fields.Add(newField);

            return this;
        }
    }

    public class CustomClass
    {
        public string ClassName { get; }
        public List<(string Name, string Type)> Fields { get; set; } = new List<(string Name, string Type)>();
        
        public CustomClass()
        {
            
        }

        public CustomClass(string className)
        {
            ClassName = className;
        }

        public override string ToString()
        {

            return base.ToString();
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

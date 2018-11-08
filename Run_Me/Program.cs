using System;
using System.Reflection;
using computer;
using adder;

namespace Run_Me
{
    class MainClass
    {
        public static void Main()
        {
            Assembly dll = Assembly.LoadFile("/Users/victorsmits/Dropbox/ECAM/BAC3/C#/Run_Me/Adder/bin/Debug/netstandard2.0/Adder.dll");
            Type type = dll.GetExportedTypes()[0];

            Computer instance = (Computer)Activator.CreateInstance(type);

            Console.WriteLine(instance.Compute(1, 2));
        }
    }
}

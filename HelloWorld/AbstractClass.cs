using System;

namespace HelloWorld
{
    internal abstract class AbstractClass
    {
        private readonly string message = "Hello C#";

        // abstract method
        public abstract void MyAbstractMethod();

        public void PrintMessage()
        {
            Console.WriteLine(message);
        }
    }

    internal class ClassA : AbstractClass
    {
        public override void MyAbstractMethod()
        {
            Console.WriteLine("C# is fun!");
        }
    }
}
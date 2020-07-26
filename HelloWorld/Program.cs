using System;

namespace HelloWorld
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");

            int x = 5, y = 10;
            x = y;
            Console.WriteLine(x + ", " + y);

            var foo = new Foo();
            foo.DoFooThings();

            var inputMgr = new InputManager();
            inputMgr.HandleInput();

            Console.Read();
            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
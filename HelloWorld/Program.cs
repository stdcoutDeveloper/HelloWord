#define _DEBUG

using System;

namespace HelloWorld
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                NullableTypesTest e = new NullableTypesTest();
                e.Test();
                GC.Collect();
            }
            catch (Exception e)
            {
#if(_DEBUG)
                Console.WriteLine("An error has occurred: " + e.Message);
#endif
            }

            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            // Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
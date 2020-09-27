using System;

namespace HelloWorld
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var counter = new {TheNumberOfCounting = 10};
            Console.WriteLine($"the number of counting is {counter.TheNumberOfCounting}");

            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            // Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
using System;

namespace HelloWorld
{
    internal interface IShape
    {
        int myNumber { get; set; }

        void DoSomething();
    }

    internal class Dummy : IShape
    {
        private int data;

        public int myNumber
        {
            get => data;
            set
            {
                if (value < 0)
                    data = 0;
                else
                    data = value;
            }
        }

        public void DoSomething()
        {
            Console.WriteLine("The number is {0}.", myNumber);
        }
    }
}
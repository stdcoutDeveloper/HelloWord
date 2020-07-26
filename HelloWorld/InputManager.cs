using System;

namespace HelloWorld
{
    internal class InputManager
    {
        public void HandleInput()
        {
            Console.WriteLine("Enter anything you'd like to here...");
            var userInput = Console.ReadLine();
            Console.WriteLine("You've just entered: " + userInput);

            try
            {
                var number = Convert.ToInt32(userInput);
                Console.WriteLine(number);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
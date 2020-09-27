using System;

namespace HelloWorld
{
    internal class TheCSharpPlayerGuide
    {
        /// <summary>
        /// </summary>
        public enum DaysOfWeek
        {
            SUNDAY = 5,
            MONDAY,
            TUESDAY,
            WEDNESDAY,
            THURSDAY,
            FRIDAY,
            SATURDAY
        }

        public void TestEnumerations()
        {
            var today = DaysOfWeek.SUNDAY;
            if (today == DaysOfWeek.SUNDAY)
                Console.WriteLine("Today is off work");

            var dayAsInt = (int) DaysOfWeek.SUNDAY;
            var yesterday = (DaysOfWeek) dayAsInt;
        }

        /// <summary>
        ///     Takes two numbers and multiplies them together, returning the result.
        /// </summary>
        /// <param name="a">The first number to multiply</param>
        /// <param name="b">The second number to multiply</param>
        /// <returns>The product of the two input numbers</returns>
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static void MethodThatUsesRecursion()
        {
            MethodThatUsesRecursion();
        }

        /// <summary>
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int Factorial(int number)
        {
            // We establish our "base case" here. When we get to this point, we're done.
            if (number == 1)
                return 1;

            return number * Factorial(number - 1);
        }

        /// <summary>
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public static int Fibonacci(int position)
        {
            // determine base case
            if (position == 1 || position == 2)
                return 1;

            return Fibonacci(position - 1) + Fibonacci(position - 2);
        }

        public void TestReferenceTypes()
        {
            string message = null;
            Console.WriteLine(message);

            var a = 3;
            var b = a;
            b++; // b = 4, a = 3
            Console.WriteLine("a = " + a + ", b = " + b);

            int[] arrayA = {1, 2, 3};
            var arrayB = arrayA;
            arrayB[0] = 17;
            Console.WriteLine(arrayA[0]); // This will print out 17.
        }

        public void TestRandom()
        {
            Console.Write("Enter the number of dice to roll: ");
            var numberOfDice = Convert.ToInt32(Console.ReadLine());

            var random = new Random();
            var sum = 0;

            //int aRandomNumber = random.Next();
            //Console.WriteLine(aRandomNumber);

            for (var i = 0; i < numberOfDice; i++)
            {
                var dieRoll = random.Next(6) + 1; // Add one, because Next(6) gives us 0 to 5.
                sum += dieRoll;

                Console.WriteLine("The " + (i + 1) + ": " + dieRoll);
            }

            Console.WriteLine("The sum of numbers you've rolled: " + sum);
        }
    }
}
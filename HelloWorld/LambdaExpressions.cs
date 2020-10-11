using System.Collections.Generic;
using System.Linq;

namespace HelloWorld
{
    internal class LambdaExpressions
    {
        private readonly int[] internalNumbers = {1, 2, 3};

        // read-only property
        public int X { get; }

        // indexer
        public int this[int index] => internalNumbers[index];

        // overload operator
        public static int operator +(LambdaExpressions a, LambdaExpressions b)
        {
            return a.X + b.X;
        }

        // expression-bodied members
        public int ComputeSquare(int value)
        {
            return value * value;
        }

        public void Test()
        {
        }

        public static IEnumerable<int> FindEvenNumbers(List<int> numbers)
        {
            bool IsEven(int number) => number % 2 == 0;

            return numbers.Where(IsEven);
        }

        bool IsNegative(int x) => x < 0;
    }
}
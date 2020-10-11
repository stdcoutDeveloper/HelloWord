using System;

namespace HelloWorld
{
    internal class ListOfNumbers
    {
        private int[] numbers;

        public ListOfNumbers()
        {
            numbers = new int[0];
        }

        public int Size => numbers.Length;

        public void AddNumber(int number)
        {
            var temp = numbers;

            numbers = new int[numbers.Length + 1];
            for (var i = 0; i < numbers.Length - 1; i++)
                numbers[i] = temp[i];

            numbers[numbers.Length - 1] = number;
        }

        public int GetNumber(int index)
        {
            return numbers[index];
        }

        public void PrintNumbers()
        {
            foreach (var element in numbers)
                Console.Write(element + " ");

            Console.WriteLine();
        }
    }

    internal class MyList
    {
        private object[] numbers;

        public MyList()
        {
            numbers = new object[0];
        }

        public int Size => numbers.Length;

        public void AddNumber(object number)
        {
            var temp = numbers;

            numbers = new object[numbers.Length + 1];
            for (var i = 0; i < numbers.Length - 1; i++)
                numbers[i] = temp[i];

            numbers[numbers.Length - 1] = number;
        }

        public object GetNumber(int index)
        {
            return numbers[index];
        }

        public void PrintNumbers()
        {
            foreach (var element in numbers)
                Console.Write(element + " ");

            Console.WriteLine();
        }
    }
}
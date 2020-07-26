using System;
using System.Collections.Generic;

namespace HelloWorld
{
    internal class Foo
    {
        private readonly char grade_;
        private readonly float hourlyRate_;
        private readonly bool isPromoted_;
        private readonly decimal money_;
        private readonly int numberOfEmployees_;

        private readonly double numberOfHours_;
        private readonly byte userAge_;

        public Foo()
        {
            userAge_ = 20;
            numberOfEmployees_ = 200;

            numberOfHours_ = 5120.5;
            hourlyRate_ = 60.5F;
            money_ = 10.0M;

            grade_ = 'A';
            isPromoted_ = true;
        }

        public void DoFooThings()
        {
            PrintOutProperties();

            int x = 5, y = 10;
            x = y;
            Console.WriteLine(x);

            var z = (int) 20.9;
            Console.WriteLine(z);

            // int[] userAgeArr = {21, 22, 23, 24, 25};
            var userAgeArr = new int[5];
            userAgeArr = new[] {22, 25, 24, 23, 21};

            for (var i = 0; i < userAgeArr.Length; i++)
                Console.Write(userAgeArr[i] + " ");

            Array.Sort(userAgeArr);
            Console.Write("\n");

            foreach (var i in userAgeArr)
                Console.Write(i + " ");

            var message = "\nHello";
            Console.WriteLine(message);

            var userAgeLst = new List<int>();
            userAgeLst.Add(10);
            userAgeLst.Add(20);

            Console.WriteLine("List has " + userAgeLst.Count + " elements.");

            userAgeLst.Clear();

            var results = 80;
            Console.WriteLine("{0}! You scored {1} marks for your test.", "Good morning", results);
            Console.WriteLine("Deposit = {0:C}. Account balance = {1:C}.", 2125, 12345.678);
        }

        private void PrintOutProperties()
        {
            Console.WriteLine(userAge_);
            Console.WriteLine(numberOfEmployees_);
            Console.WriteLine(numberOfHours_);
            Console.WriteLine(hourlyRate_);
            Console.WriteLine(money_);
            Console.WriteLine(grade_);
            Console.WriteLine(isPromoted_);
        }
    }
}
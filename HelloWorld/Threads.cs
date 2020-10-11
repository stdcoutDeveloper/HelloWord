using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Threads
    {
        private DivisionProblem threadLock = new DivisionProblem() { Dividend = 1 };

        public static void CountTo100()
        {
            for (int i = 0; i < 100; i++)
            {
                //Thread.Sleep(500);
                Console.WriteLine(i + 1);
            }
        }

        public void Test()
        {
            Thread thread1 = new Thread(Increment);
            thread1.Start();
            Thread thread2 = new Thread(Increment);
            thread2.Start();
            Thread thread3 = new Thread(Increment);
            thread3.Start();

            thread1.Join();
            thread2.Join();
            thread3.Join();

            Console.WriteLine(threadLock.Dividend);
        }

        public void Increment()
        {
            threadLock.Dividend++;
        }

        public static void CountToNumber(object input)
        {
            int n = (int)input;
            for (int i = 0; i < n; i++)
                Console.WriteLine(i + 1);
        }

        public static void Divide(object input)
        {
            DivisionProblem problem = (DivisionProblem)input;
            problem.Quotient = problem.Dividend / problem.Divisor;
        }

        public static void JumpTenTimes(object idOfFrog)
        {
            int id = (int)idOfFrog;
            Random random = new Random();
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Frog {id} jumped");
                Thread.Sleep(random.Next(1) * 1000);
            }
            Console.WriteLine($"Frog {id} finished!");
        }
    }

    class DivisionProblem
    {
        public double Dividend { get; set; }

        public double Divisor { get; set; }

        public double Quotient { get; set; }
    }
}

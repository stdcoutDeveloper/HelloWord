using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Foo
    {
        private byte userAge_ = 20;
        private int numberOfEmployees_ = 200;

        private double numberOfHours_ = 5120.5;
        private float hourlyRate_ = 60.5F;
        private decimal money_ = 10.0M;

        private char grade_ = 'A';

        private bool isPromoted_ = true;

        public void DoFooThings()
        {
            int x = 5, y = 10;
            x = y;
            Console.WriteLine(x);

            int z = (int) 20.9;
        }
    }
}

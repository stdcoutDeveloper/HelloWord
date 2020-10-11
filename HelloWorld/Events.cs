using System;

namespace HelloWorld
{
    internal class Point
    {
        private double x, y;

        public double X
        {
            get => x;
            set
            {
                OnNumberChanged((int) x, (int) value);
                x = value;
                OnPointChanged(); // raise event
                //Event(this);
            }
        }

        public double Y
        {
            get => y;
            set
            {
                OnNumberChanged((int) y, (int) value);
                y = value;
                OnPointChanged(); // raise event
            }
        }

        // define an event
        public event EventHandler PointChanged;

        public event EventHandler<NumberChangedEventArgs> NumberChanged;

        //public event Action<Point> Event;

        public void OnPointChanged()
        {
            if (PointChanged != null)
                PointChanged(this, EventArgs.Empty);
        }

        public void OnNumberChanged(int originalValue, int newValue)
        {
            if (NumberChanged != null)
                NumberChanged(this, new NumberChangedEventArgs(originalValue, newValue));
        }

        public override string ToString()
        {
            return X + ", " + Y;
        }
    }

    internal class Events
    {
        //public void HandleEvent(Point point)
        //{
        //    // Do something here
        //    Console.WriteLine("Delegate using Action<Point>: " + point);
        //}

        // event handler
        public void HandlePointChanged(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("Handling event.");

            var point = sender as Point;
            if (point != null)
                Console.WriteLine(point);
        }

        public void HandleNumberChanged(object sender, NumberChangedEventArgs args)
        {
            Console.WriteLine($"The original value of {args.Original} is now {args.New}.");
        }

        public void Test()
        {
            var point = new Point();
            Console.WriteLine(point);

            // attach event handler to event
            point.PointChanged += HandlePointChanged;
            point.NumberChanged += HandleNumberChanged;
            //point.Event += HandleEvent;

            point.X = 5;

            // detach
            //point.PointChanged -= HandlePointChanged;
            //point.Event -= HandleEvent;

            point.Y = 7;
        }
    }

    public class NumberChangedEventArgs : EventArgs
    {
        public NumberChangedEventArgs(int originalValue, int newValue)
        {
            Original = originalValue;
            New = newValue;
        }

        public int Original { get; }

        public int New { get; }
    }
}
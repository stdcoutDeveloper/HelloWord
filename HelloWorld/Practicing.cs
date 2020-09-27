namespace HelloWorld
{
    internal class Color
    {
        private readonly int blue_;
        private readonly int green_;
        private int alpha_;
        private int red_;

        public Color(int red, int green, int blue, int alpha)
        {
            red_ = red;
            green_ = green;
            blue_ = blue;
            alpha_ = alpha;
        }

        public Color(int red, int green, int blue)
        {
            red_ = red;
            green_ = green;
            blue_ = blue;
            alpha_ = 255;
        }

        public int GetRed()
        {
            return red_;
        }

        public void SetRed(int red)
        {
            red_ = red;
        }

        public double GetGrayscale()
        {
            return (red_ + green_ + blue_) / 3.0;
        }
    }

    internal class Ball
    {
        private Color color_;
        private int numberOfThrown_;
        private int size_;

        public Ball(int size, int red, int green, int blue)
        {
            size_ = size;
            color_ = new Color(red, green, blue);
            numberOfThrown_ = 0;
        }

        /// <summary>
        ///     Properties
        /// </summary>
        public int Size
        {
            get => size_;
            set
            {
                if (value < 0)
                    size_ = 0;
                else
                    size_ = value;
            }
        }

        public int NumberOfThrown { get; set; }

        public void Pop()
        {
            size_ = 0;
        }

        public void Throw()
        {
            if (size_ != 0)
                numberOfThrown_++;
        }

        public int GetNumberOfThrown()
        {
            return numberOfThrown_;
        }
    }

    internal class Player
    {
        private readonly int score_;

        public Player()
        {
            score_ = 10;
        }

        public int Score { get; set; }

        public int GetScore()
        {
            return score_;
        }
    }

    internal class Time
    {
        public int Seconds { get; set; }

        /// <summary>
        ///     https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-operator
        /// </summary>
        public int Minutes => Seconds / 60;
    }

    internal class Vector2
    {
        public Vector2(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; }

        public double Y { get; }
    }

    internal class Counter
    {
        public Counter()
        {
            TheNumberOfCounting = 0;
        }

        public int TheNumberOfCounting { get; set; }

        public void Increase()
        {
            TheNumberOfCounting++;
        }

        public void Decrease()
        {
            TheNumberOfCounting--;
        }
    }
}
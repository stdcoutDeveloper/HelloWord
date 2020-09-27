namespace HelloWorld
{
    public enum CHESS_PIECES_TYPE
    {
        UNKNOWN = ' ',
        X = 'X',
        O = 'O'
    }

    internal class Vector
    {
        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }
    }

    internal class ChessPieces
    {
        public ChessPieces(char type, Vector position)
        {
            Type = type;
            Position = position;
        }

        public char Type { get; set; }

        public Vector Position { get; set; }
    }
}
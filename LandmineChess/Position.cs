namespace LandmineChess
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            var p = (Position)obj;
            if (p == null) return false;

            return X == p.X && Y == p.Y;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

using System;

namespace VRPTW.Concret
{
    public class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }
        
        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }
        
        public int GetDistance(Coordinate coordinate)
        {
            return Math.Abs(X - coordinate.X) + Math.Abs(Y - coordinate.Y);
        }
        
    }
}
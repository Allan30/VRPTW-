using System;

namespace VRPTW.Concret
{
    public class Coordinate
    {
        private int X { get; set; }
        private int Y { get; set; }
        
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
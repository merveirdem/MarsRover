using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Area
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Area(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }
        public bool checkMaxPosition(int x, int y)
        {
            if(x < 0 || x > this.X || y < 0 || y > this.Y)
            {
                return false;
            }
            return true;
        }

    }
}

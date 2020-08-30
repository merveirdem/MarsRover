using MarsRover.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
   public class RoverPosition
    {
        public int X { get; set; }
        public int Y { get; set; }
        public DirectionsEnum Direction { get; set; }

        public RoverPosition(int x, int y, DirectionsEnum direction)
        {
            this.X = x;
            this.Y = y;
            this.Direction = direction;
        }
    }
}

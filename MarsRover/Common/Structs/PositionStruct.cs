using MarsRover.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Common.Structs
{
    public struct PositionStruct
    {
        public int x;
        public int y;
        public DirectionsEnum Direction;

        public PositionStruct(int x, int y, DirectionsEnum Direction)
        {
            this.x = x;
            this.y = y;
            this.Direction = Direction;
        }
    }
}

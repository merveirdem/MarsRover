using MarsRover.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class RoverSystem
    {

        public Area CreateArea(int x, int y)
        {
            return new Area(x, y);
        }
        public RoverPosition SetCurrentPosition(int x, int y, DirectionsEnum direction)
        {
            return new RoverPosition(x, y, direction);
        }
        public Rover CreateRover(Area area,RoverPosition roverPosition, string movementLetter)
        {
            return new Rover(area, roverPosition, movementLetter);
        }

        public void MoveRover(Rover rover)
        {
            rover.Move();
        }

    }
}

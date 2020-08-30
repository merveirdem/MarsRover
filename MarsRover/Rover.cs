using MarsRover.Common;
using MarsRover.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Rover
    {
        public Area Area { get; set; }
        public RoverPosition RoverPosition { get; set; }
        public string MovementLetters { get; set; }
        private Messages Messages;

        public Rover(Area area ,RoverPosition roverPosition, string movementLetters)
        {
            this.Area = area;
            this.RoverPosition = roverPosition;
            this.MovementLetters = movementLetters;
            this.Messages = new Messages();
        }


        public void Move()
        {
            foreach (var move in MovementLetters)
            {
                if (Area.checkMaxPosition(this.RoverPosition.X, this.RoverPosition.Y))
                {
                    switch (move)
                    {
                        case 'M':
                            this.MoveInSameDirection();
                            break;
                        case 'L':
                            this.TurnLeft();
                            break;
                        case 'R':
                            this.TurnRight();
                            break;
                    }
                }
                else
                {
                    throw new Exception(Messages.CannotMoreMaxPosition);
                }

            }
        }

        private void TurnLeft()
        {
            switch (this.RoverPosition.Direction)
            {
                case DirectionsEnum.N:
                    this.RoverPosition.Direction = DirectionsEnum.W;
                    break;
                case DirectionsEnum.S:
                    this.RoverPosition.Direction = DirectionsEnum.E;
                    break;
                case DirectionsEnum.E:
                    this.RoverPosition.Direction = DirectionsEnum.N;
                    break;
                case DirectionsEnum.W:
                    this.RoverPosition.Direction = DirectionsEnum.S;
                    break;
                default:
                    break;
            }
        }
        private void MoveInSameDirection()
        {
            switch (this.RoverPosition.Direction)
            {
                case DirectionsEnum.N:
                    this.RoverPosition.Y += 1;
                    break;
                case DirectionsEnum.S:
                    this.RoverPosition.Y -= 1;
                    break;
                case DirectionsEnum.E:
                    this.RoverPosition.X += 1;
                    break;
                case DirectionsEnum.W:
                    this.RoverPosition.X -= 1;
                    break;
                default:
                    break;
            }
        }

        private void TurnRight()
        {
            switch (this.RoverPosition.Direction)
            {
                case DirectionsEnum.N:
                    this.RoverPosition.Direction = DirectionsEnum.E;
                    break;
                case DirectionsEnum.S:
                    this.RoverPosition.Direction = DirectionsEnum.W;
                    break;
                case DirectionsEnum.E:
                    this.RoverPosition.Direction = DirectionsEnum.S;
                    break;
                case DirectionsEnum.W:
                    this.RoverPosition.Direction = DirectionsEnum.N;
                    break;
                default:
                    break;
            }
        }
    }
}

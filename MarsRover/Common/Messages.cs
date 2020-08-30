using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Common
{
    public class Messages
    {
        internal Messages()
        {
        }

        public  string EmptyMaxPositions
        {
            get
            {
                return "Max point can't be empty! Please input the maximum position. Example:x,y";
            }
        }
        public string EmptyStartPositions
        {
            get
            {
                return "Start position can't be empty! Please input the start position. Example:x,y,Direction(E,S,W,N)";
            }
        }
        public string EmptyMovementLetters
        {
            get
            {
                return "Movement letters can't be empty! Please input the movement Letters. Example:LMRLM (L or M or R)";
            }
        }
        public string WrongCountMaxPositions
        {
            get
            {
                return "Cannot be more or less than two positions. Enter the maximum position Example:x,y";
            }
        }
        public string WrongCountStartPositions
        {
            get
            {
                return "Cannot be more or less than three positions. Enter the start position Example:x,y,Direction(E,S,W,N)";
            }
        }
        public string WrongTypeMaxPositions
        {
            get
            {
                return "x or y coordinate of the maximum position is not a number. Please enter a number.";
            }
        }
        public string WrongTypeStartPositions
        {
            get
            {
                return "x or y coordinate of the maximum position is not a number or Direction is wrong. Please enter the correct format. Example:x,y,Direction(E,S,W,N)";
            }
        }
        public string WrongTypeMovementLetter
        {
            get
            {
                return "Movement letters are wrong. Please enter the correct format. Example:LMRMMR (L or M or R)";
            }
        }
        public string InputMaxPoint
        {
            get
            {
                return "Input Max Point.Example:x,y";
            }
        }
        public string InputStartPosition
        {
            get
            {
                return "Input start coordinate x y Direction(E,W,S,N) Example: 1 7 E";
            }
        }
        public string InputMoveDirections
        {
            get
            {
                return "Input the move directions(LMRLMLM)";
            }
        }
        

        public string CannotMoreMaxPosition
        {
            get
            {
                return "Rover position cannot be more than maximum position";
            }
        }
    }
}

using MarsRover.Common;
using MarsRover.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover.Common.Validator
{
    public class InputValidator
    {
        public Messages messages;

        public InputValidator()
        {
            this.messages = new Messages();
        }
       
        public void MaxPositionValidate(out int x, out int y)
        {
            Console.WriteLine(messages.InputMaxPoint);
            var maxPoint = Console.ReadLine();
            var splitMax = new List<string>();

            while (string.IsNullOrEmpty(maxPoint))
            {
                Console.WriteLine(messages.EmptyMaxPositions);
                maxPoint = Console.ReadLine();
            }
            splitMax = maxPoint.Split(',').ToList();
            while (splitMax.Count != 2 || string.IsNullOrEmpty(maxPoint))
            {
                if (string.IsNullOrEmpty(maxPoint))
                    Console.WriteLine(messages.EmptyMaxPositions);
                else
                    Console.WriteLine(messages.WrongCountMaxPositions);
                maxPoint = Console.ReadLine();
                splitMax = maxPoint.Split(',').ToList();
            }
            while (string.IsNullOrEmpty(maxPoint) || (splitMax.Count != 2) || (int.TryParse(splitMax[0], out x) == false || int.TryParse(splitMax[1], out y) == false))
            {
                if (string.IsNullOrEmpty(maxPoint))
                    Console.WriteLine(messages.EmptyMaxPositions);
                else if (splitMax.Count != 2)
                    Console.WriteLine(messages.WrongCountMaxPositions);
                else
                    Console.WriteLine(messages.WrongTypeMaxPositions);
                maxPoint = Console.ReadLine();
                splitMax = maxPoint.Split(',').ToList();
            }

        }

        public void StartPositionValidate(out int x, out int y, out DirectionsEnum direction)
        {
            Console.WriteLine(messages.InputStartPosition);
            var startPosition = Console.ReadLine();
            var splitPosition = new List<string>();
            Object directionObj;
            while (string.IsNullOrEmpty(startPosition))
            {
                Console.WriteLine(messages.EmptyStartPositions);
                startPosition = Console.ReadLine();

            }
            splitPosition = startPosition.Split(',').ToList();
            while (splitPosition.Count != 3 || string.IsNullOrEmpty(startPosition))
            {
                if (string.IsNullOrEmpty(startPosition))
                    Console.WriteLine(messages.EmptyStartPositions);
                else
                    Console.WriteLine(messages.WrongCountStartPositions);
                startPosition = Console.ReadLine();
                splitPosition = startPosition.Split(',').ToList();

            }
            while (string.IsNullOrEmpty(startPosition) || (splitPosition.Count != 3) ||
                (int.TryParse(splitPosition[0], out x) == false ||
                int.TryParse(splitPosition[1], out y) == false ||
                 Enum.TryParse(typeof(DirectionsEnum), splitPosition[2], out directionObj) == false
                ))
            {
                if (string.IsNullOrEmpty(startPosition))
                    Console.WriteLine(messages.EmptyStartPositions);
                else if (splitPosition.Count != 3)
                    Console.WriteLine(messages.WrongCountStartPositions);
                else
                    Console.WriteLine(messages.WrongTypeStartPositions);
                startPosition = Console.ReadLine();
                splitPosition = startPosition.Split(',').ToList();
            }

            direction = (DirectionsEnum)directionObj;
        }

        public void MovementLettersValidate(out string movementLetters)
        {
            Console.WriteLine(messages.InputMoveDirections);
             movementLetters = Console.ReadLine().ToUpper();
            var splitPosition = new List<string>();

            while (string.IsNullOrEmpty(movementLetters))
            {
                Console.WriteLine(messages.EmptyMovementLetters);
                movementLetters = Console.ReadLine().ToUpper();

            }

            for (int i = 0; i < movementLetters.Length; i++)

            {
                while (!CheckMovementLetters(movementLetters[i]))
                {
                    Console.WriteLine(messages.WrongTypeMovementLetter);
                    i = -1;
                    movementLetters = Console.ReadLine().ToUpper();


                    break;
                }

            }
        }
        public bool CheckMovementLetters(char letter)
        {
            switch (letter)
            {

                case 'M':
                    return true;
                    break;
                case 'L':
                    return true;
                    break;
                case 'R':
                    return true;
                    break;
                default:
                    return false;


            }

        }
    }
}

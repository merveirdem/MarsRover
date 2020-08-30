using MarsRover.Common.Structs;
using MarsRover.Common.Validator;
using System;
using System.Linq;
namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaStruct areaStruct = new AreaStruct();
            PositionStruct positionStruct = new PositionStruct();
            string movementLetter = "";
            try
            {
                InputValidator inputValidator = new InputValidator();
                inputValidator.MaxPositionValidate(out areaStruct.x,out areaStruct.y);
                inputValidator.StartPositionValidate(out positionStruct.x, out positionStruct.y, out positionStruct.Direction);
                inputValidator.MovementLettersValidate(out movementLetter);

                RoverSystem system = new RoverSystem();
                Area area = system.CreateArea(areaStruct.x, areaStruct.y);
                RoverPosition currentPosition = system.SetCurrentPosition(positionStruct.x, positionStruct.y, positionStruct.Direction);
                Rover rover = system.CreateRover(area, currentPosition, movementLetter);
                system.MoveRover(rover);
                Console.WriteLine($"Last position of the rover:{rover.RoverPosition.X} {rover.RoverPosition.Y} {rover.RoverPosition.Direction.ToString()}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

    }
}

using MarsRover;
using MarsRover.Common.Enums;
using NUnit.Framework;

namespace MarsRoverTest
{
    public class Tests
    {
        private RoverSystem roverSystem;
        [SetUp]
        public void Setup()
        {

            roverSystem = new RoverSystem();
        }

        [Test]
        public void TestScenario_12N_LMLMLMLMM()
        {
            Area area = roverSystem.CreateArea(5, 5);
            RoverPosition currentRoverPosition = roverSystem.SetCurrentPosition(1, 2, DirectionsEnum.N);
            Rover rover = new Rover(area,currentRoverPosition,"LMLMLMLMM");

            roverSystem.MoveRover(rover);

            var actualOutput = $"{rover.RoverPosition.X} {rover.RoverPosition.Y} {rover.RoverPosition.Direction.ToString()}";
            var expectedOutput = "1 3 N";

            Assert.AreEqual(expectedOutput, actualOutput);
        }
        [Test]
        public void TestScenario_33E_MRRMMRMRRM()
        {
            Area area = roverSystem.CreateArea(5, 5);
            RoverPosition currentRoverPosition = roverSystem.SetCurrentPosition(3, 3, DirectionsEnum.E);
            Rover rover = new Rover(area, currentRoverPosition, "MMRMMRMRRM");

            roverSystem.MoveRover(rover);

            var actualOutput = $"{rover.RoverPosition.X} {rover.RoverPosition.Y} {rover.RoverPosition.Direction.ToString()}";
            var expectedOutput = "5 1 E";

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
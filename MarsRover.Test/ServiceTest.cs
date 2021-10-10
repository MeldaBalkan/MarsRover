using MarsRover.Business;
using MarsRover.Entity;
using Xunit;

namespace MarsRover.Test {
    public class ServiceTest {
        [Fact]
        public void MoveRover_WhenInputMockData_EqualExpectedValue() {
            RoverService roverService = new RoverService();
            Plateau mockPlateau = new Plateau {
                SizeX = 5,
                SizeY = 5,
            };
            Rover mockRover = new Rover {
                LocationX = 1,
                LocationY = 2,
                Rotation = "N",
                IsInPlateau = true
            };
            string[] mockMoveData = { "L", "M", "L", "M", "L", "M", "L", "M", "M" };
            roverService.MoveRover(mockRover, mockMoveData, mockPlateau);
            string expectedResult = mockRover.LocationX + " " + mockRover.LocationY + " " + mockRover.Rotation;
            Assert.Equal("1 3 N", expectedResult);
        }
    }
}

using MarsRover.Business;
using MarsRover.Entity;
using System;

namespace MarsRover.UI {
    class Program {
        static void Main(string[] args) {

            RoverService roverService = new RoverService();
            Plateau plateau = new Plateau {
                SizeX = 5,
                SizeY = 5
            };
            string[] positionRover1 = { "1", "2", "N" };
            string[] moveData = { "L", "M", "L", "M", "L", "M", "L", "M", "M" };

            Rover marsRover1 = new Rover {
                LocationX = Convert.ToInt32(positionRover1[0]),
                LocationY = Convert.ToInt32(positionRover1[1]),
                Rotation = positionRover1[2],
                IsInPlateau = true
            };
            roverService.MoveRover(marsRover1, moveData, plateau); 

            Console.WriteLine(marsRover1.Rotation);
            Console.ReadKey();
        }
    }
}

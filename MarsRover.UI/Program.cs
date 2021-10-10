using MarsRover.Business;
using MarsRover.Entity;
using System;

namespace MarsRover.UI {
    class Program {
        static void Main(string[] args) {
            //5 5
            //1 2 N
            //L M L M L M L M M
            // 3 3 E
            // M M R M M R M R R M
            RoverService roverService = new RoverService();
            Console.WriteLine("Input Plateau Size: (ForExample : 5 5)");
            string[] plateauSize = Console.ReadLine().Trim().Split(' ');

            Plateau plateau = new Plateau {
                SizeX = Convert.ToInt32(plateauSize[0]),
                SizeY = Convert.ToInt32(plateauSize[1]),
            };

            Console.WriteLine("Input Position Rover1: (ForExample : 1 2 N)");
            string[] positionRover1= Console.ReadLine().ToUpper().Trim().Split(' ');
       
            Console.WriteLine("Input Move Data1: (ForExample : L M L M)");
            string[] moveData = Console.ReadLine().ToUpper().Trim().Split(' ');

            Console.WriteLine("Input Position Rover2: (ForExample : 1 2 N)");
            string[] positionRover2 = Console.ReadLine().ToUpper().Trim().Split(' ');

            Console.WriteLine("Input Move Data2: (ForExample : L M L M)");
            string[] moveData2 = Console.ReadLine().ToUpper().Trim().Split(' ');

            Rover marsRover1 = new Rover {
                LocationX = Convert.ToInt32(positionRover1[0]),
                LocationY = Convert.ToInt32(positionRover1[1]),
                Rotation = positionRover1[2],
                IsInPlateau = true
            };
            Rover marsRover2 = new Rover {
                LocationX = Convert.ToInt32(positionRover2[0]),
                LocationY = Convert.ToInt32(positionRover2[1]),
                Rotation = positionRover2[2],
                IsInPlateau = true
            };
            roverService.MoveRover(marsRover1, moveData, plateau);
            roverService.MoveRover(marsRover2, moveData2, plateau);

            if (marsRover1.IsInPlateau) {
                Console.WriteLine(marsRover1.LocationX.ToString() + ' ' + marsRover1.LocationY + ' ' + marsRover1.Rotation);
            }
            else {
                Console.WriteLine("Mars Rover1 Out Of Plateau");
            }
            
            if (marsRover2.IsInPlateau) {
                Console.WriteLine(marsRover2.LocationX.ToString() + ' ' + marsRover2.LocationY + ' ' + marsRover2.Rotation);
            }
            else {
                Console.WriteLine("Mars Rover2 Out Of Plateau");
            }            
            if(marsRover1.LocationX == marsRover2.LocationX && marsRover1.LocationY == marsRover2.LocationY) {
                Console.WriteLine("Crashed");
            }
            Console.ReadKey();
        }
    }
}

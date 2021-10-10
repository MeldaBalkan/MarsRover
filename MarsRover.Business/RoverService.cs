using MarsRover.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Business {
    public class RoverService {
        public void MoveRover(Rover rover,string[] moveData,Plateau plateau) {
            foreach (string move in moveData) {
                switch (move) {
                    case "L":
                        rover.Rotation = OperationHelper.LeftRotationDictionary[rover.Rotation];
                        break;
                    case "R":
                        rover.Rotation = OperationHelper.RightRotationDictionary[rover.Rotation];
                        break;
                    case "M":
                        if(rover.Rotation == "N") {
                            rover.LocationY++;
                        }
                        else if(rover.Rotation == "S") {
                            rover.LocationY--;
                        }
                        else if (rover.Rotation == "W") {
                            rover.LocationX--;
                        }
                        else if (rover.Rotation == "E") {
                            rover.LocationX++;
                        }
                        break;
                    default:
                        //doNothing
                        break;
                }
                if (!CheckPlateau(plateau, rover)) {
                    rover.IsInPlateau = false;
                    return;
                }
            }
        }

        public bool CheckPlateau(Plateau plateau, Rover rover) {
            if (rover.LocationX < 0 || rover.LocationY < 0) {
                return false;
            }
            else if (rover.LocationX > plateau.SizeX || rover.LocationY > plateau.SizeY) {
                return false;
            }
            else {
                return true;
            }
        }
    }
}

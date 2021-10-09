using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Entity
{
    public class Rover {
        public int LocationX { get; set; }
        public int LocationY { get; set; }
        public string Rotation { get; set; }
        public bool IsInPlateau { get; set; }
    }
}

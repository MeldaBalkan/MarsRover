using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Business {
    public class OperationHelper {

        public static Dictionary<string, string> LeftRotationDictionary = new Dictionary<string, string> {
            {"W","S" },
            {"S","E" },
            {"E","N" },
            {"N","W" }
        };

        public static Dictionary<string, string> RightRotationDictionary = new Dictionary<string, string> {
            {"S","W" },
            {"W","N" },
            {"N","E" },
            {"E","S" }
        };
    }
}

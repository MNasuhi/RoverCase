using ConsoleApp1.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class Rover
    {
        public int X { get; set; }
        public int Y { get; set; }
        public DirectionsEnum Direction { get; set; }
    }
}

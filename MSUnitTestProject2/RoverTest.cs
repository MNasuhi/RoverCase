using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1;
using ConsoleApp1.Business.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSUnitTestProject2
{
    [TestClass]
    public class RoverTest
    {
        [TestMethod]
        public void Rover_WhenLengthDifferent3_Error()
        {
            var rov = new RoverManager();
            rov.Rover("3", "5 5");
            rov.Rover("2 2", "5 5");
            rov.Rover(" 2 2", "5 5");
            rov.Rover("6 6 6 6", "5 5");
        }

        [TestMethod]
        public void Rover_WhenFirst2CharacterNotInt_Error()
        {
            var rov = new RoverManager();
            rov.Rover("3 f N", "5 5");
            rov.Rover("f 8 W", "5 5");
            rov.Rover("T R E", "5 5");
        }

        [TestMethod]
        public void Rover_WhenLastCharacterNotDirection_Error()
        {
            var rov = new RoverManager();
            rov.CheckDirection("S");
            rov.CheckDirection("3");
            rov.CheckDirection("k");
        }

        [TestMethod]
        public void Rover_WhenOutOffLimits_Error()
        {
            var rov = new RoverManager();
            rov.Rover("7 3 N", "5 5");
            rov.Rover("2 8 W", "4 4");
            rov.Rover("9 9 E", "5 5");
        }

        [TestMethod]
        public void Rover_WhenCorrectInput_Success()
        {
            var rov = new RoverManager();
            rov.Rover("1 3 N", "5 5");
            rov.Rover("2 2 W", "4 4");
        }
    }
}

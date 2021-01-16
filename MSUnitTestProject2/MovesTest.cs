using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1;
using ConsoleApp1.Business.Concrete;
using ConsoleApp1.Models;
using ConsoleApp1.Models.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSUnitTestProject2
{
    [TestClass]
    public class MovesTest
    {
        [TestMethod]
        public void Moves_WhenWrongInput_Error()
        {
            var mv = new MovesManager();
            var rov = new Rover()
            {
                X = 1,
                Y = 2,
                Direction = DirectionsEnum.N
            };
            mv.Moves("LMRS", rov);
            mv.Moves("esloR", rov);
            mv.Moves("omc", rov);
        }

        [TestMethod]
        public void Moves_WhenCorrectInput_Success()
        {
            var mv = new MovesManager();
            var rov = new Rover()
            {
                X = 1,
                Y = 2,
                Direction = DirectionsEnum.N
            };
            mv.Moves("LMR", rov);
            mv.Moves("MMLM", rov);
            mv.Moves("MMLMMR", rov);
        }

        [TestMethod]
        public void TurnLeft()
        {
            var mv = new MovesManager();
            var rov = new Rover()
            {
                X = 1,
                Y = 2,
                Direction = DirectionsEnum.N
            };
            mv.TurnLeft(rov);
            Assert.AreEqual(DirectionsEnum.W, rov.Direction);
        }

        [TestMethod]
        public void TurnRight()
        {
            var mv = new MovesManager();
            var rov = new Rover()
            {
                X = 1,
                Y = 2,
                Direction = DirectionsEnum.N
            };
            mv.TurnRight(rov);
            Assert.AreEqual(DirectionsEnum.E, rov.Direction);
        }

        [TestMethod]
        public void MoveForward_Y_Success()
        {
            var mv = new MovesManager();
            var rov = new Rover()
            {
                X = 1,
                Y = 2,
                Direction = DirectionsEnum.N
            };
            mv.MoveForward(rov);
            Assert.AreEqual(3, rov.Y);
        }

        [TestMethod]
        public void MoveForward_X_Success()
        {
            var mv = new MovesManager();
            var rov = new Rover()
            {
                X = 1,
                Y = 2,
                Direction = DirectionsEnum.E
            };
            mv.MoveForward(rov);
            Assert.AreEqual(2, rov.X);
        }
    }
}

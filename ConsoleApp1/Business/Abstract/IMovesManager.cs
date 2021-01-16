using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Business.Abstract
{
    public interface IMovesManager
    {
        void Moves(string Values, Rover rov);
        Rover TurnLeft(Rover rov);
        Rover TurnRight(Rover rov);
        Rover MoveForward(Rover rov);
    }
}

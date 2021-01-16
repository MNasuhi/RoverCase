using ConsoleApp1.Business.Abstract;
using ConsoleApp1.Business.Constants;
using ConsoleApp1.Models;
using ConsoleApp1.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Business.Concrete
{
    public class MovesManager: IMovesManager
    {
        public void Moves(string Values, Rover rov)
        {
            char[] ch = Values.ToCharArray();

            foreach (var item in ch)
            {
                if (item == 'L')
                {
                    TurnLeft(rov);
                }
                else if (item == 'M')
                {
                    MoveForward(rov);
                }
                else if (item == 'R')
                {
                    TurnRight(rov);
                }
                else
                {
                    Console.WriteLine(Messages.ErrorValue);
                }

            }

        }



        public Rover TurnLeft(Rover rov)
        {
            var a = DirectionsConvert.DirectionEnumId(rov.Direction);
            if (a - 1 < 1)
            {
                rov.Direction = DirectionsConvert.DirectionEnum(4);
            }
            else
            {
                rov.Direction = DirectionsConvert.DirectionEnum(a - 1);
            }
            return rov;
        }

        public Rover TurnRight(Rover rov)
        {
            var a = DirectionsConvert.DirectionEnumId(rov.Direction);
            if (a + 1 > 4)
            {
                rov.Direction = DirectionsConvert.DirectionEnum(1);
            }
            else
            {
                rov.Direction = DirectionsConvert.DirectionEnum(a + 1);
            }
            return rov;
        }

        public Rover MoveForward(Rover rov)
        {

            if (rov.Direction == DirectionsEnum.N)
            {
                rov.Y = rov.Y + 1;
            }
            else if (rov.Direction == DirectionsEnum.S)
            {
                rov.Y = rov.Y - 1;
            }
            else if (rov.Direction == DirectionsEnum.E)
            {
                rov.X = rov.X + 1;
            }
            else
            {
                rov.X = rov.X - 1;
            }
            return rov;
        }
    }
}

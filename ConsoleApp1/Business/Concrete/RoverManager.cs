using ConsoleApp1.Business.Abstract;
using ConsoleApp1.Business.Constants;
using ConsoleApp1.Models;
using ConsoleApp1.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Business.Concrete
{
    public class RoverManager: IRoverManager
    {
        public Rover Rover(string Values, string Limits)
        {
            Rover rov = new Rover();
            string[] InitialValues = Values.Split(" ");
            string[] MaxValues = Limits.Split(" ");
            if (InitialValues.Length != 3)
            {
                Console.WriteLine(Messages.ErrorRoverLocation);
            }
            else if (Control(null, InitialValues[0]) == false || Control(null, InitialValues[1]) == false || Control(null, InitialValues[2]) != false)
            {
                Console.WriteLine(Messages.ErrorValue);
            }
            else if (CheckDirection(InitialValues[2]) == false)
            {
                Console.WriteLine(Messages.ErrorInput);
            }
            else if (Convert.ToInt32(InitialValues[0]) > Convert.ToInt32(MaxValues[0]) || Convert.ToInt32(InitialValues[1]) > Convert.ToInt32(MaxValues[1]))
            {
                Console.WriteLine(Messages.ErrorInput);
            }
            else
            {
                rov.X = Convert.ToInt32(InitialValues[0]);
                rov.Y = Convert.ToInt32(InitialValues[1]);
                rov.Direction = DirectionsConvert.DirectionEnum(Convert.ToChar(InitialValues[2]));
            }
            return rov;
        }

        public bool Control(string[] Values, string Value)
        {
            try
            {

                if (Value != null && Convert.ToInt32(Value).GetType() == typeof(int))
                {
                    return true;
                }

                if (Values.Length >= 1)
                {
                    foreach (var item in Values)
                    {
                        if (Convert.ToInt32(item).GetType() == typeof(int))
                        {
                            return true;
                        }
                    }
                }

            }
            catch (Exception e)
            {
                if (e.GetType() != typeof(FormatException))
                {
                    Console.WriteLine(Messages.UnexpectedError + e.ToString());
                }

            }

            return false;

        }

        public bool CheckDirection(string Value)
        {
            if (Value == "N" || Value == "E" || Value == "S" || Value == "W")
            {
                return true;
            }
            return false;
        }
    }
}

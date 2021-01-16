using ConsoleApp1.Business.Abstract;
using ConsoleApp1.Business.Constants;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Business.Concrete
{
    public class RectangularManager:IRectangularManager
    {
        public Rectangular Rectangular(string Values)
        {
            Rectangular rec = new Rectangular();
            string[] MaxValues = Values.Split(" ");

            if (MaxValues.Length != 2)
            {
                Console.WriteLine(Messages.ErrorRectangular);
            }
            else if (Control(MaxValues, null) == false)
            {
                Console.WriteLine(Messages.ErrorValue);
            }
            else if (Convert.ToInt32(MaxValues[0]) < 0 || Convert.ToInt32(MaxValues[1]) < 0)
            {
                Console.WriteLine(Messages.ErrorInput);
            }
            else
            {
                rec.Xmax = Convert.ToInt32(MaxValues[0]);
                rec.Ymax = Convert.ToInt32(MaxValues[1]);
            }
            return rec;
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
    }
}

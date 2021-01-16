using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Business.Abstract
{
    public interface IRoverManager
    {
        Rover Rover(string Values, string Limits);
        bool Control(string[] Values, string Value);
        bool CheckDirection(string Value);
    }
}

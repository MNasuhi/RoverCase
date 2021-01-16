using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Business.Abstract
{
    public interface IRectangularManager
    {
        Rectangular Rectangular(string Values);
        bool Control(string[] Values, string Value);
    }
}

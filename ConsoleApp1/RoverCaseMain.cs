using ConsoleApp1.Business.Abstract;
using ConsoleApp1.Business.Concrete;
using System;

namespace ConsoleApp1
{
    public class RoverCaseMain
    {


        static void Main(string[] args)
        {
            var rectangularManager = new RectangularManager();
            var roverManager = new RoverManager();
            var movesManager = new MovesManager();

            string rectangular = Console.ReadLine();            
            var rec = rectangularManager.Rectangular(rectangular);
            

            string rover = Console.ReadLine();
            var rov = roverManager.Rover(rover, rectangular);

            string moves = Console.ReadLine();
            movesManager.Moves(moves,rov);

            string rover2 = Console.ReadLine();
            var rov2 = roverManager.Rover(rover2, rectangular);

            string moves2 = Console.ReadLine();
            movesManager.Moves(moves2,rov2);

            Console.WriteLine(rov.X + " " + rov.Y + " " + rov.Direction);
            Console.WriteLine(rov2.X + " " + rov2.Y + " " + rov2.Direction);

            Console.ReadLine();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Models.Enums
{
    public enum DirectionsEnum : int
    {
        N,
        E,
        S,
        W

    }

    public class DirectionsConvert
    {
        public DirectionsEnum DirectionsEnum { get; set; }

        public int Id { get; set; }
        public char Character { get; set; }



        public static DirectionsEnum DirectionEnum(char ch)
        {
            List<DirectionsConvert> Directions = new List<DirectionsConvert>
            {
                new DirectionsConvert { DirectionsEnum = DirectionsEnum.N, Id = 1, Character = 'N' },
                new DirectionsConvert { DirectionsEnum = DirectionsEnum.E, Id = 2, Character = 'E' },
                new DirectionsConvert { DirectionsEnum = DirectionsEnum.S, Id = 3, Character = 'S' },
                new DirectionsConvert { DirectionsEnum = DirectionsEnum.W, Id = 4, Character = 'W' }
            };
            return Directions.Where(x => x.Character == ch).SingleOrDefault().DirectionsEnum;

        }

        public static DirectionsEnum DirectionEnum(int DirectionEnumsId)
        {
            List<DirectionsConvert> Directions = new List<DirectionsConvert>
            {
                new DirectionsConvert { DirectionsEnum = DirectionsEnum.N, Id = 1, Character = 'N' },
                new DirectionsConvert { DirectionsEnum = DirectionsEnum.E, Id = 2, Character = 'E' },
                new DirectionsConvert { DirectionsEnum = DirectionsEnum.S, Id = 3, Character = 'S' },
                new DirectionsConvert { DirectionsEnum = DirectionsEnum.W, Id = 4, Character = 'W' }

            };
            return Directions.Where(x => x.Id == DirectionEnumsId).SingleOrDefault().DirectionsEnum;

        }

        public static int DirectionEnumId(DirectionsEnum DirectionsEnums)
        {
            List<DirectionsConvert> Directions = new List<DirectionsConvert>
            {
                new DirectionsConvert { DirectionsEnum = DirectionsEnum.N, Id = 1, Character = 'N' },
                new DirectionsConvert { DirectionsEnum = DirectionsEnum.E, Id = 2, Character = 'E' },
                new DirectionsConvert { DirectionsEnum = DirectionsEnum.S, Id = 3, Character = 'S' },
                new DirectionsConvert { DirectionsEnum = DirectionsEnum.W, Id = 4, Character = 'W' }
            };
            return Directions.Where(x => x.DirectionsEnum == DirectionsEnums).SingleOrDefault().Id;

        }
    }
}

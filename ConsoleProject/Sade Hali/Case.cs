using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Sade_Hali
{
    public static class Case
    {
        public static string Left(string w)
        {
            switch (w)
            {
                case "N":
                    return "W";
                case "W":
                    return "S";
                case "S":
                    return "E";
                case "E":
                    return "N";
                default:
                    return "H";
            }
        }
        public static string Right(string w)
        {
            switch (w)
            {
                case "N":
                    return "E";
                case "W":
                    return "N";
                case "S":
                    return "W";
                case "E":
                    return "S";
                default:
                    return "H";
            }
        }
        public static Coordinate Move(string w, Coordinate coordiante)
        {
            switch (w)
            {
                case "N":
                    coordiante.y++;
                    break;
                case "W":
                    coordiante.x--;
                    break;
                case "S":
                    coordiante.y--;
                    break;
                case "E":
                    coordiante.x++;
                    break;
                default:
                    break;
            }
            return coordiante;
        }
    }
}

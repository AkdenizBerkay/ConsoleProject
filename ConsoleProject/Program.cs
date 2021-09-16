using ConsoleProject.Concretes;
using ConsoleProject.Helper;
using ConsoleProject.Manager;
using ConsoleProject.Model;
using ConsoleProject.Sade_Hali;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Mars XCoordinateMaxValue and YCoordinateMaxValue");
            var value = Console.ReadLine();
            var values = value.Split(' ');
            Mars mars = new Mars(Convert.ToInt32(values[0]), Convert.ToInt32(values[1]));


            Console.WriteLine("Enter Start Point And Direction");
            var input = Console.ReadLine();
            var inputs = input.Split(' ');

            Rover rover = new Rover();

            rover.way = inputs[2];
            rover.x = Convert.ToInt32(inputs[0]);
            rover.y = Convert.ToInt32(inputs[1]);

            Console.WriteLine("Enter Commands");
            var commands = Console.ReadLine();
            var result = Utilities.ApplyCommands(mars, rover, commands);
            Console.WriteLine(result);

            #region Sade Hali
            Coordinate coordiante = new Coordinate();
            coordiante.x = 1;
            coordiante.y = 2;
            var w = "N";

            string komutlar = "LMLMLMLMM";

            foreach (char komut in komutlar.ToList())
            {
                if (komut.Equals('L'))
                {
                    w = Case.Left(w);
                }
                if (komut.Equals('R'))
                {
                    w = Case.Right(w);
                }
                if (komut.Equals('M'))
                {
                    coordiante = Case.Move(w, coordiante);
                }
            }

            Console.WriteLine(coordiante.x + " " + coordiante.y + " " + w);

            #endregion

            Console.ReadLine();
        }

    }
}

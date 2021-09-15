using ConsoleProject.Concretes;
using ConsoleProject.Helper;
using ConsoleProject.Manager;
using ConsoleProject.Model;
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
            Console.ReadLine();
        }

    }
}

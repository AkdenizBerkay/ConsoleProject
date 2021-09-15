using ConsoleProject.Abstracts;
using ConsoleProject.Concretes;
using ConsoleProject.Manager;
using ConsoleProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Helper
{
    public static class Utilities
    {
        public static Direction getDirection(Rover rover)
        {
            Direction direction;
            switch (rover.way)
            {
                case "E":
                    direction = new East(rover);
                    break;
                case "S":
                    direction = new South(rover);
                    break;
                case "W":
                    direction = new West(rover);
                    break;
                default:
                    direction = new North(rover);
                    break;
            }
            return direction;
        }


        public static bool CheckRoverLocation(Rover rover, Mars mars)
        {
            if (rover.x > mars.column || rover.y > mars.row || rover.x < 0 || rover.y < 0)
            {
                return false;
            }
            return true;
        }

        public static string ApplyCommands(Mars mars, Rover rover, string commands)
        {
            var commandList = commands.ToUpper().ToList();

            CommandController commandController = new CommandController();


            CommandManager commandManager = new CommandManager(rover, mars);
            foreach (var command in commandList)
            {
                if (command.Equals('M'))
                {
                    commandController.TakeCommands(new M(commandManager));
                }
                if (command.Equals('L'))
                {
                    commandController.TakeCommands(new L(commandManager));
                }
                if (command.Equals('R'))
                {
                    commandController.TakeCommands(new R(commandManager));
                }
            }

            commandController.ExecuteOrders();

            return rover.x + " " + rover.y + " " + rover.way;
        }
    }
}

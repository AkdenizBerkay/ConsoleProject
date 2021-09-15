using ConsoleProject.Abstracts;
using ConsoleProject.Helper;
using ConsoleProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Manager
{
    public class CommandManager
    {
        private Rover rover;
        private Mars mars;
        public CommandManager(Rover rover, Mars mars)
        {
            this.rover = rover;
            this.mars = mars;
        }
        public Direction GetDirection()
        {
            return Utilities.getDirection(this.rover);
        }

        public Rover GetRover()
        {
            return this.rover;
        }
        public Mars GetMars()
        {
            return this.mars;
        }
    }
}

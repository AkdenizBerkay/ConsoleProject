using ConsoleProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Abstracts
{
    public abstract class Direction
    {
        public Rover rover;
        public Direction(Rover rover)
        {
            this.rover = rover;
        }
        public abstract void TurnLeft();
        public abstract void TurnRight();
        public abstract void MoveForward();
    }
}

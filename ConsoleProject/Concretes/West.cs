using ConsoleProject.Abstracts;
using ConsoleProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Concretes
{
    public class West : Direction
    {
        public West(Rover rover) : base(rover)
        {
        }

        public override void MoveForward()
        {
            base.rover.x--;
        }

        public override void TurnLeft()
        {
            base.rover.way = "S";
        }

        public override void TurnRight()
        {
            base.rover.way = "N";
        }
    }
}

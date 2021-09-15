using ConsoleProject.Abstracts;
using ConsoleProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Concretes
{
    public class East : Direction
    {
        public East(Rover rover) : base(rover)
        {
        }

        public override void MoveForward()
        {
            base.rover.x++;
        }

        public override void TurnLeft()
        {
            base.rover.way = "N";
        }

        public override void TurnRight()
        {
            base.rover.way = "S";
        }
    }
}

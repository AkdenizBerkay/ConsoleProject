using ConsoleProject.Abstracts;
using ConsoleProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Concretes
{
    public class North : Direction
    {
        public North(Rover rover) : base(rover)
        {
        }

        public override void MoveForward()
        {
            base.rover.y++;
        }

        public override void TurnLeft()
        {
            base.rover.way = "W";
        }

        public override void TurnRight()
        {
            base.rover.way = "E";
        }
    }
}

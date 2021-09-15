using ConsoleProject.Abstracts;
using ConsoleProject.Helper;
using ConsoleProject.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Concretes
{
    public class M : Command
    {
        public M(CommandManager CommandManager) : base(CommandManager)
        {
        }

        public override void Execute()
        {
            base.CommandManager.GetDirection().MoveForward();
            if(!Utilities.CheckRoverLocation(base.CommandManager.GetRover(), base.CommandManager.GetMars()))
            {
                throw new Exception("Rover left orbit");
            }
        }
    }
}

using ConsoleProject.Abstracts;
using ConsoleProject.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Concretes
{
    public class R : Command
    {
        public R(CommandManager CommandManager) : base(CommandManager)
        {
        }

        public override void Execute()
        {
            base.CommandManager.GetDirection().TurnRight();
        }
    }
}

using ConsoleProject.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Abstracts
{
    public abstract class Command
    {
        protected CommandManager CommandManager;
        public Command(CommandManager CommandManager)
        {
            this.CommandManager = CommandManager;
        }
        public abstract void Execute();
    }
}

using ConsoleProject.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Manager
{
    public class CommandController
    {
        List<Command> Commands = new List<Command>();

        public void TakeCommands(Command coomand)
        {
            Commands.Add(coomand);
        }

        public void ExecuteOrders()
        {
            Commands.ForEach(k => k.Execute());
        }
    }
}

using Command_Keeper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Command_Keeper.Data
{
    public class MockCommandKeeperRepo : ICommandKeeperRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command(1,"one","one","one"),
                new Command(2,"two","two","two"),
                new Command(3,"three","three","three"),
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command(0,"test","test","test");
        }
    }
}

using Command_Keeper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Command_Keeper.Data
{
    public interface ICommandKeeperRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
    }
}

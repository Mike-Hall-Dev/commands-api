using Command_Keeper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Command_Keeper.Data
{
    public class SqlCommandKeeperRepo : ICommandKeeperRepo
    {
        private readonly CommandKeeperContext _context;

        public SqlCommandKeeperRepo(CommandKeeperContext context)
        {
            _context = context;
        }
        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }
    }
}

using Command_Keeper.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Command_Keeper.Data
{
    public class CommandKeeperContext : DbContext
    {
        public CommandKeeperContext(DbContextOptions<CommandKeeperContext> opt) : base(opt)
        {
        }

        public DbSet<Command> Commands { get; set; }
    }
}

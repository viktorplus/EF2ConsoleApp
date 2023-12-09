using Microsoft.EntityFrameworkCore;
using Models;
namespace DBContext
{
    public class CommandContext: DbContext
    {
        public DbSet<Command> Commands { get; set; }
        public CommandContext(DbContextOptions<CommandContext> options) : base(options)
        {
        }
    }
}

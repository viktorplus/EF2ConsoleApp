using Microsoft.EntityFrameworkCore;
using Models;
namespace DBContext
{
    public class CommandContext: DbContext
    {
        //public string connectionString = @"Data Source=HomeDE\SQLEXPRESS;Initial Catalog=Game2DB;Integrated Security=True;Encrypt=False";
        public string ConnectionString = @"Data Source=HOMEDE\SQLEXPRESS;Initial Catalog=Game2DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public DbSet<Command> Commands { get; set; }
        public CommandContext()
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}

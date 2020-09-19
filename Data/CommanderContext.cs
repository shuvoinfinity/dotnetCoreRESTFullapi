using Microsoft.EntityFrameworkCore;
using RESTapi.Models;

namespace RESTapi.Data
{
    public class CommanderContext : DbContext{
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {
            
        }
        public DbSet<Command> Commands { get; set; }
    
    }
}
using System.Collections.Generic;
using System.Linq;
using RESTapi.Models;

namespace RESTapi.Data
{

    public class SqlCommanderContext : ICommanderRepo
    {
        private readonly CommanderContext _context;

        public SqlCommanderContext(CommanderContext context)
        {
            _context = context;
        }
        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(x => x.Id == id);
        }
    }
}

using System.Collections.Generic;
using RESTapi.Models;

namespace RESTapi.Data
{
    public interface ICommanderRepo{
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
    }
}
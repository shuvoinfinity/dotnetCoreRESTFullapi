using System.Collections.Generic;
using RESTapi.Models;

namespace RESTapi.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            return new List<Command>{
                new Command{Id= 0, HowTo ="Boiled an Egg", Line="Line 1", Platform = "Platform 1"},
                new Command{Id= 1, HowTo ="Boiled an Egg 1", Line="Line 2", Platform = "Platform 2"},
                new Command{Id= 2, HowTo ="Boiled an Egg 2", Line="Line 3", Platform = "Platform 3"}
            };            
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id= 0, HowTo ="Boiled an Egg", Line="Line 1", Platform = "Platform 1"};
        }
    }
}